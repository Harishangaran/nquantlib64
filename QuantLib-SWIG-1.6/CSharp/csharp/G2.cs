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

public class G2 : ShortRateModel {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal G2(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.G2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(G2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~G2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_G2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public G2(YieldTermStructureHandle termStructure, double a, double sigma, double b, double eta, double rho) : this(NQuantLibcPINVOKE.new_G2__SWIG_0(YieldTermStructureHandle.getCPtr(termStructure), a, sigma, b, eta, rho), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public G2(YieldTermStructureHandle termStructure, double a, double sigma, double b, double eta) : this(NQuantLibcPINVOKE.new_G2__SWIG_1(YieldTermStructureHandle.getCPtr(termStructure), a, sigma, b, eta), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public G2(YieldTermStructureHandle termStructure, double a, double sigma, double b) : this(NQuantLibcPINVOKE.new_G2__SWIG_2(YieldTermStructureHandle.getCPtr(termStructure), a, sigma, b), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public G2(YieldTermStructureHandle termStructure, double a, double sigma) : this(NQuantLibcPINVOKE.new_G2__SWIG_3(YieldTermStructureHandle.getCPtr(termStructure), a, sigma), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public G2(YieldTermStructureHandle termStructure, double a) : this(NQuantLibcPINVOKE.new_G2__SWIG_4(YieldTermStructureHandle.getCPtr(termStructure), a), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public G2(YieldTermStructureHandle termStructure) : this(NQuantLibcPINVOKE.new_G2__SWIG_5(YieldTermStructureHandle.getCPtr(termStructure)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double discount(double t) {
    double ret = NQuantLibcPINVOKE.G2_discount(swigCPtr, t);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
