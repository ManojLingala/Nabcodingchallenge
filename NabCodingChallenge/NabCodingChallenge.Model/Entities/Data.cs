using System;
using NabCodingChallenge.Model.Interfaces;

namespace NabCodingChallenge.Model.Entities
{
    public class Data :IData
    {
        public Data()
        {
        }
		
		public string Gender { get; set; }
		//public Pets pets{ get; set; }
    }
}
