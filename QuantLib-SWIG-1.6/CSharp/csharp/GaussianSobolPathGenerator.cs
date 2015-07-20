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

public class GaussianSobolPathGenerator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GaussianSobolPathGenerator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GaussianSobolPathGenerator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GaussianSobolPathGenerator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_GaussianSobolPathGenerator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GaussianSobolPathGenerator(StochasticProcess1D process, double length, uint steps, GaussianLowDiscrepancySequenceGenerator rsg, bool brownianBridge) : this(NQuantLibcPINVOKE.new_GaussianSobolPathGenerator(StochasticProcess1D.getCPtr(process), length, steps, GaussianLowDiscrepancySequenceGenerator.getCPtr(rsg), brownianBridge), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SamplePath next() {
    SamplePath ret = new SamplePath(NQuantLibcPINVOKE.GaussianSobolPathGenerator_next(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SamplePath antithetic() {
    SamplePath ret = new SamplePath(NQuantLibcPINVOKE.GaussianSobolPathGenerator_antithetic(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
