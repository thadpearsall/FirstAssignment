using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSLabs_Assignment
{
    public class AssignmentClass
    {

        /// <summary>
        /// evauluates the list
        /// </summary>
        /// <param name="intList">List of integers to compare</param>
        /// <param name="comparisonValue">Value to compare against the list</param>
        /// <returns>A list that contains two items, an above item and a below item</returns>
        public static List<Tuple<string, int>> aboveBelow(List<int> intList, int comparisonValue)
        {
            var toRet = new List<Tuple<string, int>>();
            if (intList == null || intList.Count == 0) return null;
            var above = new Tuple<string, int>("above", intList.Where(i => i > comparisonValue).Count());
            var below = new Tuple<string, int>("below", intList.Where(i => i < comparisonValue).Count());
            toRet.Add(above);
            toRet.Add(below);
            return toRet;
        }

        public static string stringRotation(string strToRotate, int rotationCount)
        {
            string toRet = "";
            if (strToRotate == null || strToRotate == "") return "";
            if (strToRotate.Length <= rotationCount) return strToRotate; // can't rotate as the count is higher than the length of our string
            if (rotationCount < 1) return strToRotate; //cant rotate as count is lower than possible so just return original
            toRet = strToRotate.Substring(strToRotate.Length - rotationCount, rotationCount) + strToRotate.Substring(0,strToRotate.Length-rotationCount); //reorder the string
            return toRet;
        }

    }
}
