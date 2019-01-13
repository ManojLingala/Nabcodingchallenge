using System;
using System.Collections.Generic;
using System.Linq;
using NabCodingChallenge.Model.Interfaces;
using NabCodingChallenge.Model.Entities;


namespace NabCodingChallenge.Common
{
    public static class ListExtentions
    {
        /// <summary>
        /// This function to transform the ICollection to Ordered Data structure
        /// </summary>
        /// <returns>The dictionary.</returns>
        /// <param name="data">A list of object , intance of IList<IOwner>
        /// This function contains the result set with sorted and grouped information , and here we are using Sorted{Dictionary,List} for better 
        /// performane.
        public static Dictionary<string, List<string>> ToSortedDictionary(this List<IOwner> data)
        {
            var result = new Dictionary<string, List<string>>();
            List<string> petName = new List<string>();
            result.Add("Male",GetPetsBelongingToMaleOwner(data));
            result.Add("FeMale", GetPetsBelongingToFeMaleOwner(data));

            return result;
        }

      //Considering only Cat's as given in the requirement 

        public static List<string> GetPetsBelongingToMaleOwner(List<IOwner> ownerList)
        {
            List<string> maleList = new List<string>();
            foreach (var owner in ownerList)
            {
                if (owner.Gender.Equals("male", StringComparison.OrdinalIgnoreCase))
                {
                    if (owner.Pets != null)
                    {
                        foreach (var pet in owner.Pets)
                        {
                            if (pet.Type.Equals("cat", StringComparison.OrdinalIgnoreCase))
                                maleList.Add(pet.Name);
                        }
                    }
                }
            }
            maleList.Sort();

            return maleList;

        }
        //Considering only Cat's as given in the requirement 
        public static List<string> GetPetsBelongingToFeMaleOwner(List<IOwner> ownerList)
        {
            List<string> femaleList = new List<string>();
            foreach (var owner in ownerList)
            {
                if (owner.Gender.Equals("female", StringComparison.OrdinalIgnoreCase))
                {
                    if (owner.Pets != null)
                    {
                        foreach (var pet in owner.Pets)
                        {
                            if (pet.Type.Equals("cat", StringComparison.OrdinalIgnoreCase))
                                femaleList.Add(pet.Name);
                        }
                    }
                }
            }
            femaleList.Sort();
            return femaleList;

        }
    }
}
