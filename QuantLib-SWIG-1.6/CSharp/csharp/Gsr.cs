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

public class Gsr : Gaussian1dModel {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Gsr(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.Gsr_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Gsr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Gsr() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_Gsr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Gsr(YieldTermStructureHandle termStructure, DateVector volstepdates, QuoteHandleVector volatilities, QuoteHandleVector reversions, double T) : this(NQuantLibcPINVOKE.new_Gsr__SWIG_0(YieldTermStructureHandle.getCPtr(termStructure), DateVector.getCPtr(volstepdates), QuoteHandleVector.getCPtr(volatilities), QuoteHandleVector.getCPtr(reversions), T), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gsr(YieldTermStructureHandle termStructure, DateVector volstepdates, QuoteHandleVector volatilities, QuoteHandleVector reversions) : this(NQuantLibcPINVOKE.new_Gsr__SWIG_1(YieldTermStructureHandle.getCPtr(termStructure), DateVector.getCPtr(volstepdates), QuoteHandleVector.getCPtr(volatilities), QuoteHandleVector.getCPtr(reversions)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrateVolatilitiesIterative(CalibrationHelperVector helpers, OptimizationMethod method, EndCriteria endCriteria, Constraint constraint, DoubleVector weights) {
    NQuantLibcPINVOKE.Gsr_calibrateVolatilitiesIterative__SWIG_0(swigCPtr, CalibrationHelperVector.getCPtr(helpers), OptimizationMethod.getCPtr(method), EndCriteria.getCPtr(endCriteria), Constraint.getCPtr(constraint), DoubleVector.getCPtr(weights));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrateVolatilitiesIterative(CalibrationHelperVector helpers, OptimizationMethod method, EndCriteria endCriteria, Constraint constraint) {
    NQuantLibcPINVOKE.Gsr_calibrateVolatilitiesIterative__SWIG_1(swigCPtr, CalibrationHelperVector.getCPtr(helpers), OptimizationMethod.getCPtr(method), EndCriteria.getCPtr(endCriteria), Constraint.getCPtr(constraint));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calibrateVolatilitiesIterative(CalibrationHelperVector helpers, OptimizationMethod method, EndCriteria endCriteria) {
    NQuantLibcPINVOKE.Gsr_calibrateVolatilitiesIterative__SWIG_2(swigCPtr, CalibrationHelperVector.getCPtr(helpers), OptimizationMethod.getCPtr(method), EndCriteria.getCPtr(endCriteria));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
