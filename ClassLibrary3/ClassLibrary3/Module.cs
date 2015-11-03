using System;
using System.Collections.Generic;
using System.Text;
using PAT.Common.Classes.Expressions.ExpressionClass;

//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    /// <summary>
    /// The math library that can be used in your model.
    /// all methods should be declared as public static.
    /// 
    /// The parameters must be of type "int", or "int array"
    /// The number of parameters can be 0 or many
    /// 
    /// The return type can be bool, int or int[] only.
    /// 
    /// The method name will be used directly in your model.
    /// e.g. call(max, 10, 2), call(dominate, 3, 2), call(amax, [1,3,5]),
    /// 
    /// Note: method names are case sensetive
    /// </summary>
    public class Module : ExpressionValue
    {
        private static int MAX = 500;
        private static int NumOfStudent;
        private static int NumOfModules;
        private static int[] ModuleVacancy;
        private static int[][] ModuleBids;
        
        public Module(){

            ModuleVacancy = new int[MAX];
            ModuleBids = new int[MAX][];
            initialiseArray(ModuleBids, MAX, MAX);

        }

        public Module(int value, int mods){

            NumOfStudent = value;
            NumOfModules = mods;
            ModuleVacancy = new int[NumOfModules];
            //ModuleBids[NumOfStudents][NumOfModules] 
            ModuleBids = new int[NumOfStudent][];
            initialiseArray(ModuleBids, NumOfStudent, NumOfModules);


        }

        private static void initialiseArray(int[][] a, int num, int size)
        {

            for (int i = 0; i < num; i++)
            {
                a[i] = new int[size];
            }
        }

        public void copyTwoArrays(int[] ArrayA, int[] ArrayB)
        {
            for (int i = 0; i < ArrayA.Length; i++)
            {
                ArrayB[i] = ArrayA[i];
            }
        }

        public void copyTwoArrays(int[][] ArrayA, int[][] ArrayB)
        {
            for (int i = 0; i < ArrayA.Length; i++)
            {
                for (int j = 0; j < ArrayA.[i].Length; j++)
                {
                    ArrayB[i][j] = ArrayA[i][j];
                }
            }
        }

        public int getNumOfStudent()
        {
            return NumOfStudent;
        }

        public int getNumOfModules()
        {
            return NumOfModules;
        }

        public int[] getModuleVacancy()
        {
            return ModuleVacancy;
        }

        public int[][] getModuleBids()
        {
            return ModuleBids;
        }

        public void setNumOfStudents(int a)
        {
            NumOfStudent = a;
        }

        public void getNumOfModules(int b)
        {
            NumOfModules = b;
        }

        /// <summary>
        /// Please implement this method to provide the string representation of the datatype
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            String result = "";

            for (int i = 0; i < ModuleVacancy.Length; i++)
            {
                result += "Module Vacancy: ";
                result += i + ": " + ModuleVacancy[i] + "\n";
            }

            for (int i = 0; i < ModuleBids.Length; i++)
            {
                result += ". ModuleBids: ";
                for (int j = 0; j < ModuleBids[i].Length; j++)
                {
                    result += "Student " + i + ": " + "Module" + j + " : " + ModuleBids[i][j] + "\n";
                }
            }
            return result;
        }


        /// <summary>
        /// Please implement this method to return a deep clone of the current object
        /// </summary>
        /// <returns></returns>
        public override ExpressionValue GetClone()
        {
            return this;
        }


        /// <summary>
        /// Please implement this method to provide the compact string representation of the datatype
        /// </summary>
        /// <returns></returns>
        public override string ExpressionID
        {
            get { return ""; }
        }

    }
}
