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

public class Gaussian1dSwaptionEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Gaussian1dSwaptionEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.Gaussian1dSwaptionEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Gaussian1dSwaptionEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Gaussian1dSwaptionEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_Gaussian1dSwaptionEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Gaussian1dSwaptionEngine(Gaussian1dModel model, int integrationPoints, double stddevs, bool extrapolatePayoff, bool flatPayoffExtrapolation, YieldTermStructureHandle discountCurve) : this(NQuantLibcPINVOKE.new_Gaussian1dSwaptionEngine__SWIG_0(Gaussian1dModel.getCPtr(model), integrationPoints, stddevs, extrapolatePayoff, flatPayoffExtrapolation, YieldTermStructureHandle.getCPtr(discountCurve)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gaussian1dSwaptionEngine(Gaussian1dModel model, int integrationPoints, double stddevs, bool extrapolatePayoff, bool flatPayoffExtrapolation) : this(NQuantLibcPINVOKE.new_Gaussian1dSwaptionEngine__SWIG_1(Gaussian1dModel.getCPtr(model), integrationPoints, stddevs, extrapolatePayoff, flatPayoffExtrapolation), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gaussian1dSwaptionEngine(Gaussian1dModel model, int integrationPoints, double stddevs, bool extrapolatePayoff) : this(NQuantLibcPINVOKE.new_Gaussian1dSwaptionEngine__SWIG_2(Gaussian1dModel.getCPtr(model), integrationPoints, stddevs, extrapolatePayoff), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gaussian1dSwaptionEngine(Gaussian1dModel model, int integrationPoints, double stddevs) : this(NQuantLibcPINVOKE.new_Gaussian1dSwaptionEngine__SWIG_3(Gaussian1dModel.getCPtr(model), integrationPoints, stddevs), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gaussian1dSwaptionEngine(Gaussian1dModel model, int integrationPoints) : this(NQuantLibcPINVOKE.new_Gaussian1dSwaptionEngine__SWIG_4(Gaussian1dModel.getCPtr(model), integrationPoints), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gaussian1dSwaptionEngine(Gaussian1dModel model) : this(NQuantLibcPINVOKE.new_Gaussian1dSwaptionEngine__SWIG_5(Gaussian1dModel.getCPtr(model)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
