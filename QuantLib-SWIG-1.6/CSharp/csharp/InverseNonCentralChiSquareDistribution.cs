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

public class InverseNonCentralChiSquareDistribution : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InverseNonCentralChiSquareDistribution(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InverseNonCentralChiSquareDistribution obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~InverseNonCentralChiSquareDistribution() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_InverseNonCentralChiSquareDistribution(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public InverseNonCentralChiSquareDistribution(double df, double ncp, uint maxEvaluations, double accuracy) : this(NQuantLibcPINVOKE.new_InverseNonCentralChiSquareDistribution__SWIG_0(df, ncp, maxEvaluations, accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public InverseNonCentralChiSquareDistribution(double df, double ncp, uint maxEvaluations) : this(NQuantLibcPINVOKE.new_InverseNonCentralChiSquareDistribution__SWIG_1(df, ncp, maxEvaluations), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public InverseNonCentralChiSquareDistribution(double df, double ncp) : this(NQuantLibcPINVOKE.new_InverseNonCentralChiSquareDistribution__SWIG_2(df, ncp), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double call(double x) {
    double ret = NQuantLibcPINVOKE.InverseNonCentralChiSquareDistribution_call(swigCPtr, x);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
