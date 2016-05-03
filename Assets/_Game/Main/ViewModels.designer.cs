// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UnityEngine;
using UniRx;


public partial class InitViewModelBase : uFrame.MVVM.ViewModel {
    
    private P<Single> _LoadProgressProperty;
    
    private P<String> _LoadMessageProperty;
    
    public InitViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
    
    public virtual P<Single> LoadProgressProperty {
        get {
            return _LoadProgressProperty;
        }
        set {
            _LoadProgressProperty = value;
        }
    }
    
    public virtual P<String> LoadMessageProperty {
        get {
            return _LoadMessageProperty;
        }
        set {
            _LoadMessageProperty = value;
        }
    }
    
    public virtual Single LoadProgress {
        get {
            return LoadProgressProperty.Value;
        }
        set {
            LoadProgressProperty.Value = value;
        }
    }
    
    public virtual String LoadMessage {
        get {
            return LoadMessageProperty.Value;
        }
        set {
            LoadMessageProperty.Value = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
        _LoadProgressProperty = new P<Single>(this, "LoadProgress");
        _LoadMessageProperty = new P<String>(this, "LoadMessage");
    }
    
    public override void Read(ISerializerStream stream) {
        base.Read(stream);
        this.LoadProgress = stream.DeserializeFloat("LoadProgress");;
    }
    
    public override void Write(ISerializerStream stream) {
        base.Write(stream);
        stream.SerializeFloat("LoadProgress", this.LoadProgress);
    }
    
    protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
        base.FillCommands(list);
    }
    
    protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
        base.FillProperties(list);
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_LoadProgressProperty, false, false, false, false));
        // PropertiesChildItem
        list.Add(new ViewModelPropertyInfo(_LoadMessageProperty, false, false, false, false));
    }
}

public partial class InitViewModel {
    
    public InitViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
            base(aggregator) {
    }
}
