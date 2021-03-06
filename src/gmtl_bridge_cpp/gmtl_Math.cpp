// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.3 of RCSfile: free_types_cxx.tmpl,v


#include "sharppy.h"
#include <gmtl-Math-functions.h>

extern "C"
{

   // Wrapper for free function gmtl::Math::deg2Rad()
   SHARPPY_API double gmtl_Math_deg2Rad__double1(double p0)
   {
      double result;
      result = gmtl::Math::deg2Rad(p0);
      return result;
   }


   // Wrapper for free function gmtl::Math::deg2Rad()
   SHARPPY_API float gmtl_Math_deg2Rad__float1(float p0)
   {
      float result;
      result = gmtl::Math::deg2Rad(p0);
      return result;
   }


   // Wrapper for free function gmtl::Math::rad2Deg()
   SHARPPY_API double gmtl_Math_rad2Deg__double1(double p0)
   {
      double result;
      result = gmtl::Math::rad2Deg(p0);
      return result;
   }


   // Wrapper for free function gmtl::Math::rad2Deg()
   SHARPPY_API float gmtl_Math_rad2Deg__float1(float p0)
   {
      float result;
      result = gmtl::Math::rad2Deg(p0);
      return result;
   }


   // Wrapper for free function gmtl::Math::ceil()
   SHARPPY_API double gmtl_Math_ceil__double1(double p0)
   {
      double result;
      result = gmtl::Math::ceil(p0);
      return result;
   }


   // Wrapper for free function gmtl::Math::ceil()
   SHARPPY_API float gmtl_Math_ceil__float1(float p0)
   {
      float result;
      result = gmtl::Math::ceil(p0);
      return result;
   }


   // Wrapper for free function gmtl::Math::floor()
   SHARPPY_API double gmtl_Math_floor__double1(double p0)
   {
      double result;
      result = gmtl::Math::floor(p0);
      return result;
   }


   // Wrapper for free function gmtl::Math::floor()
   SHARPPY_API float gmtl_Math_floor__float1(float p0)
   {
      float result;
      result = gmtl::Math::floor(p0);
      return result;
   }


   // Wrapper for free function gmtl::Math::seedRandom()
   SHARPPY_API void gmtl_Math_seedRandom__unsigned_int1(unsigned int p0)
   {
      gmtl::Math::seedRandom(p0);
   }


   // Wrapper for free function gmtl::Math::unitRandom()
   SHARPPY_API float gmtl_Math_unitRandom__0()
   {
      float result;
      result = gmtl::Math::unitRandom();
      return result;
   }


   // Wrapper for free function gmtl::Math::rangeRandom()
   SHARPPY_API float gmtl_Math_rangeRandom__float_float2(float p0, float p1)
   {
      float result;
      result = gmtl::Math::rangeRandom(p0, p1);
      return result;
   }


} // extern "C" for free functions
