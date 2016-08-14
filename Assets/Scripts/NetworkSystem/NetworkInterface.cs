using System;
using System.Threading;
using System.Collections;
using System.Net.Sockets;
using System.Net;

public class NetworkInterface {

	private Socket socket;
	private SocketAsyncEventArgs sendEA;
	private SocketAsyncEventArgs receiveEA;
	private SocketBuffer sendBuffer;
	private SocketBuffer receiveBuffer;

	public enum ConnectionState
	{
		NotConnected,
		Connecting,
		Connected
	}

	public ConnectionState State 
	{
		get; private set;
	}

	public void ConnectTo(string ip, int port)
	{

		State = ConnectionState.NotConnected;

		socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		IPAddress[] ips = Dns.GetHostAddresses(ip);
		var addr = ips[0];
		var hostEndPoint = new IPEndPoint(addr, port);

		var connectEA = new SocketAsyncEventArgs();

		connectEA.RemoteEndPoint = hostEndPoint;
		connectEA.Completed += (object sender, SocketAsyncEventArgs e)=>{

			switch (e.LastOperation)
			{
			case SocketAsyncOperation.Connect:
				UnityEngine.Debug.Log("Connect success");
				break;
			default:
				throw new ArgumentException("The last operation completed on the socket was not a receive or send");
			}

			connectEA.Dispose();

			State = ConnectionState.Connected;
		
		};

		State = ConnectionState.Connecting;

		socket.ConnectAsync(connectEA);
	}

	public void Send(byte[] data)
	{
		sendBuffer = sendBuffer ?? new SocketBuffer(2048);

		var succ = sendBuffer.AddData(data);
		if (!succ)
		{
			//TODO
		}
		else
		{
			StartSend();
		}

	}

	private SocketAsyncEventArgs CreateSAEA(EventHandler<SocketAsyncEventArgs> completeHandler)
	{
		var saea = new SocketAsyncEventArgs();
		saea.Completed += completeHandler;

		return saea;
	}

	private void OnSendComplete(object sender, SocketAsyncEventArgs e)
	{
		if (e.SocketError == SocketError.Success)
		{
			sendBuffer.SetBytesUsed(e.BytesTransferred);

			if (sendBuffer.HasAvailableData)
			{
				StartSend();
			}
		}
	}

	private void StartSend()
	{
		sendEA = sendEA ?? CreateSAEA(new EventHandler<SocketAsyncEventArgs>(OnSendComplete));
		var raw = sendBuffer.RawBuffer;

		sendEA.SetBuffer(raw, sendBuffer.ConsumePosition, sendBuffer.CurrentPickingDataLength);
		socket.SendAsync(sendEA);
	}

	public void Process()
	{
		if (receiveBuffer.HasAvailableData)
		{
			
			var data = new byte[receiveBuffer.CurrentPickingDataLength];
			Array.Copy(receiveBuffer.RawBuffer, receiveBuffer.ConsumePosition, data, 0, receiveBuffer.CurrentPickingDataLength);

			receiveBuffer.SetBytesUsed(receiveBuffer.CurrentPickingDataLength);

			var response = System.Text.Encoding.ASCII.GetString(data);

			UnityEngine.Debug.Log("receive:" + response);

		}
	}

	public void StartReceive()
	{
		UnityEngine.Debug.Log("startReceive");
		receiveEA = receiveEA ?? CreateSAEA(new EventHandler<SocketAsyncEventArgs>(OnReceiveComplete));
		receiveBuffer = receiveBuffer ?? new SocketBuffer(64);
		var raw = receiveBuffer.RawBuffer;

		//TODO availableSpace not enough, we need space to the array end.
		receiveEA.SetBuffer(raw, receiveBuffer.ProducePosition, receiveBuffer.RawAvailableSpace);

		var isSucc = socket.ReceiveAsync(receiveEA);
		if (!isSucc)
		{
			UnityEngine.Debug.LogError(receiveEA.SocketError.ToString());
		}
	}

	private void OnReceiveComplete(object sender, SocketAsyncEventArgs e)
	{
		if (e.SocketError == SocketError.Success)
		{
			UnityEngine.Debug.LogError("receive complete success: transfered:" + e.BytesTransferred);
			receiveBuffer.SetBytesProduced(e.BytesTransferred);

			if (receiveBuffer.AvailableSpace > 0)
			{
				StartReceive();
			}
			else
			{
				UnityEngine.Debug.LogError("Space not enough to receive socket data");
			}
		}
		else

		{
			UnityEngine.Debug.LogError("receive error");
		}
	}

	internal class AsyncUserToken
	{

	}

}
