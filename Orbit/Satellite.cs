//
// Satellite.cs
//
// Copyright (c) 2014 Michael F. Henry
// Version 07/2014
//
using System;
using System.Collections.Generic;
using System.Text;

namespace Zeptomoby.OrbitTools
{
   /// <summary>
   /// Class to encapsulate a satellite.
   /// </summary>
   public class Satellite
   {
      #region Properties

      /// <summary>
      /// The satellite name.
      /// </summary>
      public string Name { get; private set; }

      /// <summary>
      /// Information related to the satellite's orbit.
      /// </summary>
      public Orbit Orbit { get; private set; }

      #endregion

      #region Construction

      /// <summary>
      /// Standard constructor.
      /// </summary>
      /// <param name="tle">TLE data.</param>
      /// <param name="name">Optional satellite name.</param>
      public Satellite(Tle tle, string name = "")
      {
         Orbit = new Orbit(tle);

         if (name == "")
         {
            Name = Orbit.SatName;
         }
         else
         {
            Name = name;
         }
      }

      #endregion

      /// <summary>
      /// Returns the ECI position of the satellite.
      /// </summary>
      /// <param name="utc">The time (UTC) of position calculation.</param>
      /// <returns>The ECI location of the satellite at the given time.</returns>
      public EciTime PositionEci(DateTime utc)
      {
         return Orbit.PositionEci(utc);
      }

      /// <summary>
      /// Returns the ECI position of the satellite.
      /// </summary>
      /// <param name="mpe">The time of position calculation, in minutes-past-epoch.</param>
      /// <returns>The ECI location of the satellite at the given time.</returns>
      public EciTime PositionEci(double mpe)
      {
         return Orbit.PositionEci(mpe);
      }
   }
}
