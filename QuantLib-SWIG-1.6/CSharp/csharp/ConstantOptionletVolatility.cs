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

public class ConstantOptionletVolatility : OptionletVolatilityStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ConstantOptionletVolatility(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.ConstantOptionletVolatility_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ConstantOptionletVolatility obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ConstantOptionletVolatility() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_ConstantOptionletVolatility(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ConstantOptionletVolatility(Date referenceDate, Calendar cal, BusinessDayConvention bdc, double volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_ConstantOptionletVolatility__SWIG_0(Date.getCPtr(referenceDate), Calendar.getCPtr(cal), (int)bdc, volatility, DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstantOptionletVolatility(Date referenceDate, Calendar cal, BusinessDayConvention bdc, QuoteHandle volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_ConstantOptionletVolatility__SWIG_1(Date.getCPtr(referenceDate), Calendar.getCPtr(cal), (int)bdc, QuoteHandle.getCPtr(volatility), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstantOptionletVolatility(uint settlementDays, Calendar cal, BusinessDayConvention bdc, double volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_ConstantOptionletVolatility__SWIG_2(settlementDays, Calendar.getCPtr(cal), (int)bdc, volatility, DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstantOptionletVolatility(uint settlementDays, Calendar cal, BusinessDayConvention bdc, QuoteHandle volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_ConstantOptionletVolatility__SWIG_3(settlementDays, Calendar.getCPtr(cal), (int)bdc, QuoteHandle.getCPtr(volatility), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
