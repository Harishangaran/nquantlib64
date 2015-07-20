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

public class QuantoForwardEuropeanEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal QuantoForwardEuropeanEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.QuantoForwardEuropeanEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(QuantoForwardEuropeanEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~QuantoForwardEuropeanEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_QuantoForwardEuropeanEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public QuantoForwardEuropeanEngine(GeneralizedBlackScholesProcess process, YieldTermStructureHandle foreignRiskFreeRate, BlackVolTermStructureHandle exchangeRateVolatility, QuoteHandle correlation) : this(NQuantLibcPINVOKE.new_QuantoForwardEuropeanEngine(GeneralizedBlackScholesProcess.getCPtr(process), YieldTermStructureHandle.getCPtr(foreignRiskFreeRate), BlackVolTermStructureHandle.getCPtr(exchangeRateVolatility), QuoteHandle.getCPtr(correlation)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}