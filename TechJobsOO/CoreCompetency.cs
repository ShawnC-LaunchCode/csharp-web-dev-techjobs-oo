﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency :JobField
    {
        //private int id { get; set; }
        //private static int nextId = 1;
        //private string value { get; set; }

        //// TODO: Change the fields to auto-implemented properties.

        //public CoreCompetency()
        //{
        //    id = nextId;
        //    nextId++;
        //}

        public CoreCompetency(string v) : base()
        {
            Value = v;
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is CoreCompetency competency &&
        //           id == competency.id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(id);
        //}

        //public override string ToString()
        //{
        //    return value;
        //}
    }
    }

