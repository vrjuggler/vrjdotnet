// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.64 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <vpr/Util/Interval.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API vpr::Interval* vpr_Interval_Interval__vpr_Interval1(const vpr::Interval* p0)
   {
      const vpr::Interval& marshal_p0 = *p0;
      vpr::Interval* obj = new vpr::Interval(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::Interval* vpr_Interval_Interval__0()
   {
      vpr::Interval* obj = new vpr::Interval();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::Interval* vpr_Interval_Interval__vpr_Uint64_vpr_Interval_Unit2(const vpr::Uint64 p0, const vpr::Interval::Unit p1)
   {
      vpr::Interval* obj = new vpr::Interval(p0, p1);
      return obj;
   }

   SHARPPY_API void delete_vpr_Interval(vpr::Interval* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method vpr::Interval::set()
   SHARPPY_API void vpr_Interval_set__vpr_Uint64_vpr_Interval_Unit2(vpr::Interval* self_, const vpr::Uint64 p0, const vpr::Interval::Unit p1)
   {
      self_->set(p0, p1);
   }


   // Wrapper for non-virtual method vpr::Interval::setf()
   SHARPPY_API void vpr_Interval_setf__float_vpr_Interval_Unit2(vpr::Interval* self_, const float p0, const vpr::Interval::Unit p1)
   {
      self_->setf(p0, p1);
   }


   // Wrapper for non-virtual method vpr::Interval::setd()
   SHARPPY_API void vpr_Interval_setd__double_vpr_Interval_Unit2(vpr::Interval* self_, const double p0, const vpr::Interval::Unit p1)
   {
      self_->setd(p0, p1);
   }


   // Wrapper for non-virtual method vpr::Interval::setNow()
   SHARPPY_API void vpr_Interval_setNow__0(vpr::Interval* self_)
   {
      self_->setNow();
   }


   // Wrapper for non-virtual method vpr::Interval::setNowReal()
   SHARPPY_API void vpr_Interval_setNowReal__0(vpr::Interval* self_)
   {
      self_->setNowReal();
   }


   // Wrapper for non-virtual method vpr::Interval::sec()
   SHARPPY_API void vpr_Interval_sec__vpr_Uint641(vpr::Interval* self_, const vpr::Uint64 p0)
   {
      self_->sec(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::sec()
   SHARPPY_API vpr::Uint64 vpr_Interval_sec__0(vpr::Interval* self_)
   {
      vpr::Uint64 result;
      result = self_->sec();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::secf()
   SHARPPY_API void vpr_Interval_secf__float1(vpr::Interval* self_, const float p0)
   {
      self_->secf(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::secf()
   SHARPPY_API float vpr_Interval_secf__0(vpr::Interval* self_)
   {
      float result;
      result = self_->secf();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::secd()
   SHARPPY_API void vpr_Interval_secd__double1(vpr::Interval* self_, const double p0)
   {
      self_->secd(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::secd()
   SHARPPY_API double vpr_Interval_secd__0(vpr::Interval* self_)
   {
      double result;
      result = self_->secd();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::msec()
   SHARPPY_API void vpr_Interval_msec__vpr_Uint641(vpr::Interval* self_, const vpr::Uint64 p0)
   {
      self_->msec(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::msec()
   SHARPPY_API vpr::Uint64 vpr_Interval_msec__0(vpr::Interval* self_)
   {
      vpr::Uint64 result;
      result = self_->msec();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::msecf()
   SHARPPY_API void vpr_Interval_msecf__float1(vpr::Interval* self_, const float p0)
   {
      self_->msecf(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::msecf()
   SHARPPY_API float vpr_Interval_msecf__0(vpr::Interval* self_)
   {
      float result;
      result = self_->msecf();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::msecd()
   SHARPPY_API void vpr_Interval_msecd__double1(vpr::Interval* self_, const double p0)
   {
      self_->msecd(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::msecd()
   SHARPPY_API double vpr_Interval_msecd__0(vpr::Interval* self_)
   {
      double result;
      result = self_->msecd();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::usec()
   SHARPPY_API void vpr_Interval_usec__vpr_Uint641(vpr::Interval* self_, const vpr::Uint64 p0)
   {
      self_->usec(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::usec()
   SHARPPY_API vpr::Uint64 vpr_Interval_usec__0(vpr::Interval* self_)
   {
      vpr::Uint64 result;
      result = self_->usec();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::usecf()
   SHARPPY_API void vpr_Interval_usecf__float1(vpr::Interval* self_, const float p0)
   {
      self_->usecf(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::usecf()
   SHARPPY_API float vpr_Interval_usecf__0(vpr::Interval* self_)
   {
      float result;
      result = self_->usecf();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::usecd()
   SHARPPY_API void vpr_Interval_usecd__double1(vpr::Interval* self_, const double p0)
   {
      self_->usecd(p0);
   }


   // Wrapper for non-virtual method vpr::Interval::usecd()
   SHARPPY_API double vpr_Interval_usecd__0(vpr::Interval* self_)
   {
      double result;
      result = self_->usecd();
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::getBaseVal()
   SHARPPY_API vpr::Uint64 vpr_Interval_getBaseVal__0(vpr::Interval* self_)
   {
      vpr::Uint64 result;
      result = self_->getBaseVal();
      return result;
   }


   // Wrapper for static method vpr::Interval::now()
   SHARPPY_API vpr::Interval* vpr_Interval_now__0()
   {
      vpr::Interval* result;
      result = new vpr::Interval(vpr::Interval::now());
      return result;
   }


   // Wrapper for reading static data member vpr::Interval::NoWait
   SHARPPY_API const vpr::Interval* vpr_Interval_NoWait_get()
   {
      return &vpr::Interval::NoWait;
   }


   // Wrapper for reading static data member vpr::Interval::NoTimeout
   SHARPPY_API const vpr::Interval* vpr_Interval_NoTimeout_get()
   {
      return &vpr::Interval::NoTimeout;
   }


   // Wrapper for reading static data member vpr::Interval::HalfPeriod
   SHARPPY_API const vpr::Interval* vpr_Interval_HalfPeriod_get()
   {
      return &vpr::Interval::HalfPeriod;
   }


   // Wrapper for non-virtual method vpr::Interval::operator ==()
   SHARPPY_API bool vpr_Interval_equal__vpr_Interval1(vpr::Interval* self_, const vpr::Interval* p0)
   {
      const vpr::Interval& marshal_p0 = *p0;
      bool result;
      result = self_->operator==(marshal_p0);
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::operator !=()
   SHARPPY_API bool vpr_Interval_not_equal__vpr_Interval1(vpr::Interval* self_, const vpr::Interval* p0)
   {
      const vpr::Interval& marshal_p0 = *p0;
      bool result;
      result = self_->operator!=(marshal_p0);
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::operator <()
   SHARPPY_API bool vpr_Interval_less_than__vpr_Interval1(vpr::Interval* self_, const vpr::Interval* p0)
   {
      const vpr::Interval& marshal_p0 = *p0;
      bool result;
      result = self_->operator<(marshal_p0);
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::operator <=()
   SHARPPY_API bool vpr_Interval_less_than_or_equal__vpr_Interval1(vpr::Interval* self_, const vpr::Interval* p0)
   {
      const vpr::Interval& marshal_p0 = *p0;
      bool result;
      result = self_->operator<=(marshal_p0);
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::operator >()
   SHARPPY_API bool vpr_Interval_greater_than__vpr_Interval1(vpr::Interval* self_, const vpr::Interval* p0)
   {
      const vpr::Interval& marshal_p0 = *p0;
      bool result;
      result = self_->operator>(marshal_p0);
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::operator +()
   SHARPPY_API vpr::Interval* vpr_Interval_add__vpr_Interval1(vpr::Interval* self_, const vpr::Interval* p0)
   {
      const vpr::Interval& marshal_p0 = *p0;
      vpr::Interval* result;
      result = new vpr::Interval(self_->operator+(marshal_p0));
      return result;
   }


   // Wrapper for non-virtual method vpr::Interval::operator -()
   SHARPPY_API vpr::Interval* vpr_Interval_subtract__vpr_Interval1(vpr::Interval* self_, const vpr::Interval* p0)
   {
      const vpr::Interval& marshal_p0 = *p0;
      vpr::Interval* result;
      result = new vpr::Interval(self_->operator-(marshal_p0));
      return result;
   }


} // extern "C" for vpr::Interval


