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

public class AmericanExercise : Exercise {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AmericanExercise(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.AmericanExercise_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AmericanExercise obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AmericanExercise() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_AmericanExercise(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public AmericanExercise(Date earliestDate, Date latestDate, bool payoffAtExpiry) : this(NQuantLibcPINVOKE.new_AmericanExercise__SWIG_0(Date.getCPtr(earliestDate), Date.getCPtr(latestDate), payoffAtExpiry), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public AmericanExercise(Date earliestDate, Date latestDate) : this(NQuantLibcPINVOKE.new_AmericanExercise__SWIG_1(Date.getCPtr(earliestDate), Date.getCPtr(latestDate)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
