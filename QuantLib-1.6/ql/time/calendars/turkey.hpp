/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2005 Sercan Atalik
 Copyright (C) 2010 StatPro Italia srl

 This file is part of QuantLib, a free-software/open-source library
 for financial quantitative analysts and developers - http://quantlib.org/

 QuantLib is free software: you can redistribute it and/or modify it
 under the terms of the QuantLib license.  You should have received a
 copy of the license along with this program; if not, please email
 <quantlib-dev@lists.sf.net>. The license is also available online at
 <http://quantlib.org/license.shtml>.

 This program is distributed in the hope that it will be useful, but WITHOUT
 ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 FOR A PARTICULAR PURPOSE.  See the license for more details.
*/

/*! \file turkey.hpp
    \brief Turkish calendar
*/

#ifndef quantlib_turkish_calendar_hpp
#define quantlib_turkish_calendar_hpp

#include <ql/time/calendar.hpp>

namespace QuantLib {

    //! Turkish calendar
    /*! Holidays for the Istanbul Stock Exchange:
        (data from
         <http://borsaistanbul.com/en/products-and-markets/official-holidays>):
        <ul>
        <li>Saturdays</li>
        <li>Sundays</li>
        <li>New Year's Day, January 1st</li>
        <li>National Sovereignty and Children’s Day, April 23rd</li>
        <li>Labour and Solidarity Day, May 1st</li>
        <li>Youth and Sports Day, May 19th</li>
        <li>Victory Day, August 30th</li>
        <li>Republic Day, October 29th</li>
        <li>Local Holidays (Kurban, Ramadan; 2004 to 2014 only) </li>
        </ul>

        \ingroup calendars
    */
    class Turkey : public Calendar {
      private:
        class Impl : public Calendar::Impl {
          public:
            std::string name() const { return "Turkey"; }
            bool isWeekend(Weekday) const;
            bool isBusinessDay(const Date&) const;
        };
      public:
        Turkey();
    };

}


#endif
