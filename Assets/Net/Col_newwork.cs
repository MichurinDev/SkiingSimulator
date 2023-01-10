using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using Normal.Realtime.Serialization;


[RealtimeModel]
public partial class Col_newwork 
{
    [RealtimeProperty(1, true, true)]
    private int _finised;
}

/* ----- Begin Normal Autogenerated Code ----- */
public partial class Col_newwork : RealtimeModel {
    public int finised {
        get {
            return _finisedProperty.value;
        }
        set {
            if (_finisedProperty.value == value) return;
            _finisedProperty.value = value;
            InvalidateReliableLength();
            FireFinisedDidChange(value);
        }
    }
    
    public delegate void PropertyChangedHandler<in T>(Col_newwork model, T value);
    public event PropertyChangedHandler<int> finisedDidChange;
    
    public enum PropertyID : uint {
        Finised = 1,
    }
    
    #region Properties
    
    private ReliableProperty<int> _finisedProperty;
    
    #endregion
    
    public Col_newwork() : base(null) {
        _finisedProperty = new ReliableProperty<int>(1, _finised);
    }
    
    protected override void OnParentReplaced(RealtimeModel previousParent, RealtimeModel currentParent) {
        _finisedProperty.UnsubscribeCallback();
    }
    
    private void FireFinisedDidChange(int value) {
        try {
            finisedDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    protected override int WriteLength(StreamContext context) {
        var length = 0;
        length += _finisedProperty.WriteLength(context);
        return length;
    }
    
    protected override void Write(WriteStream stream, StreamContext context) {
        var writes = false;
        writes |= _finisedProperty.Write(stream, context);
        if (writes) InvalidateContextLength(context);
    }
    
    protected override void Read(ReadStream stream, StreamContext context) {
        var anyPropertiesChanged = false;
        while (stream.ReadNextPropertyID(out uint propertyID)) {
            var changed = false;
            switch (propertyID) {
                case (uint) PropertyID.Finised: {
                    changed = _finisedProperty.Read(stream, context);
                    if (changed) FireFinisedDidChange(finised);
                    break;
                }
                default: {
                    stream.SkipProperty();
                    break;
                }
            }
            anyPropertiesChanged |= changed;
        }
        if (anyPropertiesChanged) {
            UpdateBackingFields();
        }
    }
    
    private void UpdateBackingFields() {
        _finised = finised;
    }
    
}
/* ----- End Normal Autogenerated Code ----- */
