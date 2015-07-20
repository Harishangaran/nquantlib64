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

public class FloatingRateBond : Bond {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FloatingRateBond(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.FloatingRateBond_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FloatingRateBond obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FloatingRateBond() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_FloatingRateBond(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, uint fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors, bool inArrears, double redemption, Date issueDate) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_0(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, fixingDays, DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors), inArrears, redemption, Date.getCPtr(issueDate)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, uint fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors, bool inArrears, double redemption) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_1(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, fixingDays, DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors), inArrears, redemption), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, uint fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors, bool inArrears) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_2(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, fixingDays, DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors), inArrears), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, uint fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_3(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, fixingDays, DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, uint fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_4(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, fixingDays, DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, uint fixingDays, DoubleVector gearings, DoubleVector spreads) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_5(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, fixingDays, DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, uint fixingDays, DoubleVector gearings) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_6(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, fixingDays, DoubleVector.getCPtr(gearings)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, uint fixingDays) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_7(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, fixingDays), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_8(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FloatingRateBond(uint settlementDays, double faceAmount, Schedule schedule, IborIndex index, DayCounter paymentDayCounter) : this(NQuantLibcPINVOKE.new_FloatingRateBond__SWIG_9(settlementDays, faceAmount, Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
