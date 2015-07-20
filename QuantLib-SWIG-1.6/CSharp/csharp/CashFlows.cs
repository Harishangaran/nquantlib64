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

public class CashFlows : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CashFlows(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CashFlows obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CashFlows() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CashFlows(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static Date startDate(Leg arg0) {
    Date ret = new Date(NQuantLibcPINVOKE.CashFlows_startDate(Leg.getCPtr(arg0)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date maturityDate(Leg arg0) {
    Date ret = new Date(NQuantLibcPINVOKE.CashFlows_maturityDate(Leg.getCPtr(arg0)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg leg, YieldTermStructure discountCurve, double zSpread, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_0(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), zSpread, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg leg, YieldTermStructure discountCurve, double zSpread, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_1(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), zSpread, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg leg, YieldTermStructure discountCurve, double zSpread, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_2(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), zSpread, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg leg, YieldTermStructureHandle discountCurve, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_3(Leg.getCPtr(leg), YieldTermStructureHandle.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg leg, YieldTermStructureHandle discountCurve, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_4(Leg.getCPtr(leg), YieldTermStructureHandle.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg leg, YieldTermStructureHandle discountCurve, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_5(Leg.getCPtr(leg), YieldTermStructureHandle.getCPtr(discountCurve), includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_6(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_7(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_8(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_9(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_10(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double npv(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_npv__SWIG_11(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg leg, YieldTermStructure discountCurve, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_0(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg leg, YieldTermStructure discountCurve, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_1(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg leg, YieldTermStructure discountCurve, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_2(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg leg, YieldTermStructureHandle discountCurve, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_3(Leg.getCPtr(leg), YieldTermStructureHandle.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg leg, YieldTermStructureHandle discountCurve, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_4(Leg.getCPtr(leg), YieldTermStructureHandle.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg leg, YieldTermStructureHandle discountCurve, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_5(Leg.getCPtr(leg), YieldTermStructureHandle.getCPtr(discountCurve), includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_6(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_7(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_8(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_9(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_10(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_bps__SWIG_11(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double atmRate(Leg leg, YieldTermStructure discountCurve, bool includeSettlementDateFlows, Date settlementDate, Date npvDate, double npv) {
    double ret = NQuantLibcPINVOKE.CashFlows_atmRate__SWIG_0(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate), npv);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double atmRate(Leg leg, YieldTermStructure discountCurve, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_atmRate__SWIG_1(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double atmRate(Leg leg, YieldTermStructure discountCurve, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_atmRate__SWIG_2(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double atmRate(Leg leg, YieldTermStructure discountCurve, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_atmRate__SWIG_3(Leg.getCPtr(leg), YieldTermStructure.getCPtr(discountCurve), includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Leg arg0, double npv, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate, double accuracy, uint maxIterations, double guess) {
    double ret = NQuantLibcPINVOKE.CashFlows_yield__SWIG_0(Leg.getCPtr(arg0), npv, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate), accuracy, maxIterations, guess);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Leg arg0, double npv, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate, double accuracy, uint maxIterations) {
    double ret = NQuantLibcPINVOKE.CashFlows_yield__SWIG_1(Leg.getCPtr(arg0), npv, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate), accuracy, maxIterations);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Leg arg0, double npv, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate, double accuracy) {
    double ret = NQuantLibcPINVOKE.CashFlows_yield__SWIG_2(Leg.getCPtr(arg0), npv, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate), accuracy);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Leg arg0, double npv, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_yield__SWIG_3(Leg.getCPtr(arg0), npv, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Leg arg0, double npv, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_yield__SWIG_4(Leg.getCPtr(arg0), npv, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Leg arg0, double npv, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_yield__SWIG_5(Leg.getCPtr(arg0), npv, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Leg arg0, InterestRate arg1, Duration.Type type, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_duration__SWIG_0(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), (int)type, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Leg arg0, InterestRate arg1, Duration.Type type, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_duration__SWIG_1(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), (int)type, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Duration.Type type, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_duration__SWIG_2(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, (int)type, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Duration.Type type, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_duration__SWIG_3(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, (int)type, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Duration.Type type, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_duration__SWIG_4(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, (int)type, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_convexity__SWIG_0(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_convexity__SWIG_1(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Leg arg0, InterestRate arg1, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_convexity__SWIG_2(Leg.getCPtr(arg0), InterestRate.getCPtr(arg1), includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_convexity__SWIG_3(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_convexity__SWIG_4(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Leg arg0, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_convexity__SWIG_5(Leg.getCPtr(arg0), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Leg leg, InterestRate yield, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_basisPointValue__SWIG_0(Leg.getCPtr(leg), InterestRate.getCPtr(yield), includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Leg leg, InterestRate yield, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_basisPointValue__SWIG_1(Leg.getCPtr(leg), InterestRate.getCPtr(yield), includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Leg leg, InterestRate yield, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_basisPointValue__SWIG_2(Leg.getCPtr(leg), InterestRate.getCPtr(yield), includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Leg leg, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_basisPointValue__SWIG_3(Leg.getCPtr(leg), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Leg leg, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_basisPointValue__SWIG_4(Leg.getCPtr(leg), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Leg leg, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_basisPointValue__SWIG_5(Leg.getCPtr(leg), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Leg leg, double npv, YieldTermStructure arg2, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate, double accuracy, uint maxIterations, double guess) {
    double ret = NQuantLibcPINVOKE.CashFlows_zSpread__SWIG_0(Leg.getCPtr(leg), npv, YieldTermStructure.getCPtr(arg2), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate), accuracy, maxIterations, guess);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Leg leg, double npv, YieldTermStructure arg2, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate, double accuracy, uint maxIterations) {
    double ret = NQuantLibcPINVOKE.CashFlows_zSpread__SWIG_1(Leg.getCPtr(leg), npv, YieldTermStructure.getCPtr(arg2), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate), accuracy, maxIterations);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Leg leg, double npv, YieldTermStructure arg2, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate, double accuracy) {
    double ret = NQuantLibcPINVOKE.CashFlows_zSpread__SWIG_2(Leg.getCPtr(leg), npv, YieldTermStructure.getCPtr(arg2), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate), accuracy);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Leg leg, double npv, YieldTermStructure arg2, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate, Date npvDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_zSpread__SWIG_3(Leg.getCPtr(leg), npv, YieldTermStructure.getCPtr(arg2), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate), Date.getCPtr(npvDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Leg leg, double npv, YieldTermStructure arg2, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.CashFlows_zSpread__SWIG_4(Leg.getCPtr(leg), npv, YieldTermStructure.getCPtr(arg2), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Leg leg, double npv, YieldTermStructure arg2, DayCounter dayCounter, Compounding compounding, Frequency frequency, bool includeSettlementDateFlows) {
    double ret = NQuantLibcPINVOKE.CashFlows_zSpread__SWIG_5(Leg.getCPtr(leg), npv, YieldTermStructure.getCPtr(arg2), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, includeSettlementDateFlows);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
