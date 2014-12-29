/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace TapQuoteAPI {

using System;
using System.Runtime.InteropServices;

public class TapAPIApplicationInfo : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIApplicationInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TapAPIApplicationInfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIApplicationInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapQuotePINVOKE.delete_TapAPIApplicationInfo(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public string AuthCode {
    set {
      TapQuotePINVOKE.TapAPIApplicationInfo_AuthCode_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIApplicationInfo_AuthCode_get(swigCPtr);
      return ret;
    } 
  }

  public string KeyOperationLogPath {
    set {
      TapQuotePINVOKE.TapAPIApplicationInfo_KeyOperationLogPath_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIApplicationInfo_KeyOperationLogPath_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIApplicationInfo() : this(TapQuotePINVOKE.new_TapAPIApplicationInfo__SWIG_0(), true) {
  }

  public TapAPIApplicationInfo(TapAPIApplicationInfo other) : this(TapQuotePINVOKE.new_TapAPIApplicationInfo__SWIG_1(TapAPIApplicationInfo.getCPtr(other)), true) {
    if (TapQuotePINVOKE.SWIGPendingException.Pending) throw TapQuotePINVOKE.SWIGPendingException.Retrieve();
  }

}

}