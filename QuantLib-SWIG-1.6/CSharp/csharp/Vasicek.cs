//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class Vasicek : ShortRateModel {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Vasicek(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.Vasicek_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vasicek obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vasicek() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_Vasicek(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Vasicek(double r0, double a, double b, double sigma, double lambda) : this(NQuantLibcPINVOKE.new_Vasicek__SWIG_0(r0, a, b, sigma, lambda), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vasicek(double r0, double a, double b, double sigma) : this(NQuantLibcPINVOKE.new_Vasicek__SWIG_1(r0, a, b, sigma), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vasicek(double r0, double a, double b) : this(NQuantLibcPINVOKE.new_Vasicek__SWIG_2(r0, a, b), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vasicek(double r0, double a) : this(NQuantLibcPINVOKE.new_Vasicek__SWIG_3(r0, a), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vasicek(double r0) : this(NQuantLibcPINVOKE.new_Vasicek__SWIG_4(r0), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vasicek() : this(NQuantLibcPINVOKE.new_Vasicek__SWIG_5(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double discount(double t) {
    double ret = NQuantLibcPINVOKE.Vasicek_discount(swigCPtr, t);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
