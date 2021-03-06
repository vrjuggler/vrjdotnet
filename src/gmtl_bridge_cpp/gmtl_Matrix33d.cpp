// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.63 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/Matrix.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::Matrix33d* gmtl_Matrix_double_3_3__Matrix__0()
   {
      gmtl::Matrix33d* obj = new gmtl::Matrix33d();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Matrix33d* gmtl_Matrix_double_3_3__Matrix__gmtl_Matrix33d1(const gmtl::Matrix33d* p0)
   {
      const gmtl::Matrix33d& marshal_p0 = *p0;
      gmtl::Matrix33d* obj = new gmtl::Matrix33d(marshal_p0);
      return obj;
   }

   SHARPPY_API void delete_gmtl_Matrix33d(gmtl::Matrix33d* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gmtl::Matrix<double,3,3>::set()
   SHARPPY_API void gmtl_Matrix_double_3_3__set__double_double_double_double_double_double_double_double_double9(gmtl::Matrix33d* self_, double p0, double p1, double p2, double p3, double p4, double p5, double p6, double p7, double p8)
   {
      self_->set(p0, p1, p2, p3, p4, p5, p6, p7, p8);
   }


   // Wrapper for non-virtual method gmtl::Matrix<double,3,3>::set()
   SHARPPY_API void gmtl_Matrix_double_3_3__set__double1(gmtl::Matrix33d* self_, const double* p0)
   {
      self_->set(p0);
   }


   // Wrapper for non-virtual method gmtl::Matrix<double,3,3>::setTranspose()
   SHARPPY_API void gmtl_Matrix_double_3_3__setTranspose__double1(gmtl::Matrix33d* self_, const double* p0)
   {
      self_->setTranspose(p0);
   }


   // Wrapper for non-virtual method gmtl::Matrix<double,3,3>::getData()
   SHARPPY_API void gmtl_Matrix_double_3_3__getData__0(gmtl::Matrix33d* self_, double* arrayHolder)
   {
      const double* temp_array;
      temp_array = self_->getData();
      for ( int i = 0; i < 9; ++i )
      {
         arrayHolder[i] = temp_array[i];
      }
   }


   // Wrapper for non-virtual method gmtl::Matrix<double,3,3>::isError()
   SHARPPY_API bool gmtl_Matrix_double_3_3__isError__0(gmtl::Matrix33d* self_)
   {
      bool result;
      result = self_->isError();
      return result;
   }


   // Wrapper for non-virtual method gmtl::Matrix<double,3,3>::setError()
   SHARPPY_API void gmtl_Matrix_double_3_3__setError__0(gmtl::Matrix33d* self_)
   {
      self_->setError();
   }


} // extern "C" for gmtl::Matrix33d

// Nested class gmtl::Matrix33d::RowAccessor.
extern "C"
{
   SHARPPY_API void delete_gmtl_Matrix33d_RowAccessor(gmtl::Matrix33d::RowAccessor* self_)
   {
      delete self_;
   }

} // extern "C" for gmtl::Matrix33d::RowAccessor


// Nested class gmtl::Matrix33d::ConstRowAccessor.
extern "C"
{
   SHARPPY_API void delete_gmtl_Matrix33d_ConstRowAccessor(gmtl::Matrix33d::ConstRowAccessor* self_)
   {
      delete self_;
   }

} // extern "C" for gmtl::Matrix33d::ConstRowAccessor



