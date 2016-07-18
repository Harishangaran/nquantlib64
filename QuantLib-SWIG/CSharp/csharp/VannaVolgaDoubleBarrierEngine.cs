//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class VannaVolgaDoubleBarrierEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VannaVolgaDoubleBarrierEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.VannaVolgaDoubleBarrierEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VannaVolgaDoubleBarrierEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VannaVolgaDoubleBarrierEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_VannaVolgaDoubleBarrierEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public VannaVolgaDoubleBarrierEngine(DeltaVolQuoteHandle atmVol, DeltaVolQuoteHandle vol25Put, DeltaVolQuoteHandle vol25Call, QuoteHandle spotFX, YieldTermStructureHandle domesticTS, YieldTermStructureHandle foreignTS, string type, bool adaptVanDelta, double bsPriceWithSmile, int series) : this(NQuantLibcPINVOKE.new_VannaVolgaDoubleBarrierEngine__SWIG_0(DeltaVolQuoteHandle.getCPtr(atmVol), DeltaVolQuoteHandle.getCPtr(vol25Put), DeltaVolQuoteHandle.getCPtr(vol25Call), QuoteHandle.getCPtr(spotFX), YieldTermStructureHandle.getCPtr(domesticTS), YieldTermStructureHandle.getCPtr(foreignTS), type, adaptVanDelta, bsPriceWithSmile, series), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public VannaVolgaDoubleBarrierEngine(DeltaVolQuoteHandle atmVol, DeltaVolQuoteHandle vol25Put, DeltaVolQuoteHandle vol25Call, QuoteHandle spotFX, YieldTermStructureHandle domesticTS, YieldTermStructureHandle foreignTS, string type, bool adaptVanDelta, double bsPriceWithSmile) : this(NQuantLibcPINVOKE.new_VannaVolgaDoubleBarrierEngine__SWIG_1(DeltaVolQuoteHandle.getCPtr(atmVol), DeltaVolQuoteHandle.getCPtr(vol25Put), DeltaVolQuoteHandle.getCPtr(vol25Call), QuoteHandle.getCPtr(spotFX), YieldTermStructureHandle.getCPtr(domesticTS), YieldTermStructureHandle.getCPtr(foreignTS), type, adaptVanDelta, bsPriceWithSmile), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public VannaVolgaDoubleBarrierEngine(DeltaVolQuoteHandle atmVol, DeltaVolQuoteHandle vol25Put, DeltaVolQuoteHandle vol25Call, QuoteHandle spotFX, YieldTermStructureHandle domesticTS, YieldTermStructureHandle foreignTS, string type, bool adaptVanDelta) : this(NQuantLibcPINVOKE.new_VannaVolgaDoubleBarrierEngine__SWIG_2(DeltaVolQuoteHandle.getCPtr(atmVol), DeltaVolQuoteHandle.getCPtr(vol25Put), DeltaVolQuoteHandle.getCPtr(vol25Call), QuoteHandle.getCPtr(spotFX), YieldTermStructureHandle.getCPtr(domesticTS), YieldTermStructureHandle.getCPtr(foreignTS), type, adaptVanDelta), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public VannaVolgaDoubleBarrierEngine(DeltaVolQuoteHandle atmVol, DeltaVolQuoteHandle vol25Put, DeltaVolQuoteHandle vol25Call, QuoteHandle spotFX, YieldTermStructureHandle domesticTS, YieldTermStructureHandle foreignTS, string type) : this(NQuantLibcPINVOKE.new_VannaVolgaDoubleBarrierEngine__SWIG_3(DeltaVolQuoteHandle.getCPtr(atmVol), DeltaVolQuoteHandle.getCPtr(vol25Put), DeltaVolQuoteHandle.getCPtr(vol25Call), QuoteHandle.getCPtr(spotFX), YieldTermStructureHandle.getCPtr(domesticTS), YieldTermStructureHandle.getCPtr(foreignTS), type), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public VannaVolgaDoubleBarrierEngine(DeltaVolQuoteHandle atmVol, DeltaVolQuoteHandle vol25Put, DeltaVolQuoteHandle vol25Call, QuoteHandle spotFX, YieldTermStructureHandle domesticTS, YieldTermStructureHandle foreignTS) : this(NQuantLibcPINVOKE.new_VannaVolgaDoubleBarrierEngine__SWIG_4(DeltaVolQuoteHandle.getCPtr(atmVol), DeltaVolQuoteHandle.getCPtr(vol25Put), DeltaVolQuoteHandle.getCPtr(vol25Call), QuoteHandle.getCPtr(spotFX), YieldTermStructureHandle.getCPtr(domesticTS), YieldTermStructureHandle.getCPtr(foreignTS)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}