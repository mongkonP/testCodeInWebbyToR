
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testCodeInWebbyToR.Ext;
using TORServices.Forms;

namespace learn.microsoft.frm
{
    //https://learn.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-7.0
    internal class frmLernArrayList : frmBase
    {
        public frmLernArrayList() { Load += (o, e) => { Task.Factory.StartNew(Test02); }; }

        ///<summary>
        ///
        /// </summary>
        void Test01()
        {
            Action<IEnumerable> PrintValues = (myList) =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("   {0}", obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            richTextBox1.WriteLine("myAL");
            richTextBox1.WriteLine("    Count:    {0}", myAL.Count);
            richTextBox1.WriteLine("    Capacity: {0}", myAL.Capacity);
            richTextBox1.Write("    Values:");
            PrintValues(myAL);
        }

        ///<summary>
        ///
        /// </summary>
        void Test02()
        {

            Action<IEnumerable, char> PrintValues = (myList, mySeparator) =>
            {

                foreach (Object obj in myList)
                    richTextBox1.Write("{0}{1}", mySeparator, obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Create a fixed-size wrapper around the ArrayList.
            ArrayList myFixedSizeAL = ArrayList.FixedSize(myAL);

            // Display whether the ArrayLists have a fixed size or not.
            richTextBox1.WriteLine("myAL {0}.", myAL.IsFixedSize ? "has a fixed size" : "does not have a fixed size");
            richTextBox1.WriteLine("myFixedSizeAL {0}.", myFixedSizeAL.IsFixedSize ? "has a fixed size" : "does not have a fixed size");
            richTextBox1.WriteLine();

            // Display both ArrayLists.
            richTextBox1.WriteLine("Initially,");
            richTextBox1.Write("Standard  :");
            PrintValues(myAL, ' ');
            richTextBox1.Write("Fixed size:");
            PrintValues(myFixedSizeAL, ' ');

            // Sort is allowed in the fixed-size ArrayList.
            myFixedSizeAL.Sort();

            // Display both ArrayLists.
            richTextBox1.WriteLine("After Sort,");
            richTextBox1.Write("Standard  :");
            PrintValues(myAL, ' ');
            richTextBox1.Write("Fixed size:");
            PrintValues(myFixedSizeAL, ' ');

            // Reverse is allowed in the fixed-size ArrayList.
            myFixedSizeAL.Reverse();

            // Display both ArrayLists.
            richTextBox1.WriteLine("After Reverse,");
            richTextBox1.Write("Standard  :");
            PrintValues(myAL, ' ');
            richTextBox1.Write("Fixed size:");
            PrintValues(myFixedSizeAL, ' ');

            // Add an element to the standard ArrayList.
            myAL.Add("AddMe");

            // Display both ArrayLists.
            richTextBox1.WriteLine("After adding to the standard ArrayList,");
            richTextBox1.Write("Standard  :");
            PrintValues(myAL, ' ');
            richTextBox1.Write("Fixed size:");
            PrintValues(myFixedSizeAL, ' ');
            richTextBox1.WriteLine();

            // Adding or inserting elements to the fixed-size ArrayList throws an exception.
            try
            {
                myFixedSizeAL.Add("AddMe2");
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
            try
            {
                myFixedSizeAL.Insert(3, "InsertMe");
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test03()
        {
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("red");
            myAL.Add("orange");
            myAL.Add("yellow");

            // Creates a read-only copy of the ArrayList.
            ArrayList myReadOnlyAL = ArrayList.ReadOnly(myAL);

            // Displays whether the ArrayList is read-only or writable.
            richTextBox1.WriteLine("myAL is {0}.", myAL.IsReadOnly ? "read-only" : "writable");
            richTextBox1.WriteLine("myReadOnlyAL is {0}.", myReadOnlyAL.IsReadOnly ? "read-only" : "writable");

            // Displays the contents of both collections.
            richTextBox1.WriteLine("\nInitially,");
            richTextBox1.WriteLine("The original ArrayList myAL contains:");
            foreach (string myStr in myAL)
                richTextBox1.WriteLine("   {0}", myStr);
            richTextBox1.WriteLine("The read-only ArrayList myReadOnlyAL contains:");
            foreach (string myStr in myReadOnlyAL)
                richTextBox1.WriteLine("   {0}", myStr);

            // Adding an element to a read-only ArrayList throws an exception.
            richTextBox1.WriteLine("\nTrying to add a new element to the read-only ArrayList:");
            try
            {
                myReadOnlyAL.Add("green");
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }

            // Adding an element to the original ArrayList affects the read-only ArrayList.
            myAL.Add("blue");

            // Displays the contents of both collections again.
            richTextBox1.WriteLine("\nAfter adding a new element to the original ArrayList,");
            richTextBox1.WriteLine("The original ArrayList myAL contains:");
            foreach (string myStr in myAL)
                richTextBox1.WriteLine("   {0}", myStr);
            richTextBox1.WriteLine("The read-only ArrayList myReadOnlyAL contains:");
            foreach (string myStr in myReadOnlyAL)
                richTextBox1.WriteLine("   {0}", myStr);
        }

        ///<summary>
        ///
        /// </summary>
        void Test04()
        {
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");

            // Creates a synchronized wrapper around the ArrayList.
            ArrayList mySyncdAL = ArrayList.Synchronized(myAL);

            // Displays the sychronization status of both ArrayLists.
            richTextBox1.WriteLine("myAL is {0}.", myAL.IsSynchronized ? "synchronized" : "not synchronized");
            richTextBox1.WriteLine("mySyncdAL is {0}.", mySyncdAL.IsSynchronized ? "synchronized" : "not synchronized");
        }

        ///<summary>
        ///
        /// </summary>
        void Test05()
        {
            // Create an empty ArrayList, and add some elements.
            ArrayList stringList = new ArrayList();

            stringList.Add("a");
            stringList.Add("abc");
            stringList.Add("abcdef");
            stringList.Add("abcdefg");

            // The Item property is an indexer, so the property name is
            // not required.
            richTextBox1.WriteLine("Element {0} is \"{1}\"", 2, stringList[2]);

            // Assigning a value to the property changes the value of
            // the indexed element.
            stringList[2] = "abcd";
            richTextBox1.WriteLine("Element {0} is \"{1}\"", 2, stringList[2]);

            // Accessing an element outside the current element count
            // causes an exception.
            richTextBox1.WriteLine("Number of elements in the list: {0}",
                stringList.Count);
            try
            {
                richTextBox1.WriteLine("Element {0} is \"{1}\"",
                    stringList.Count, stringList[stringList.Count]);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                richTextBox1.WriteLine("stringList({0}) is out of range.",
                    stringList.Count);
            }

            // You cannot use the Item property to add new elements.
            try
            {
                stringList[stringList.Count] = "42";
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                richTextBox1.WriteLine("stringList({0}) is out of range.",
                    stringList.Count);
            }

            richTextBox1.WriteLine();
            for (int i = 0; i < stringList.Count; i++)
            {
                richTextBox1.WriteLine("Element {0} is \"{1}\"", i,
                    stringList[i]);
            }

            richTextBox1.WriteLine();
            foreach (object o in stringList)
            {
                richTextBox1.WriteLine(o);
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test06()
        {
            Action<IEnumerable, char> PrintValues = (myList, mySeparator) =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("{0}{1}", mySeparator, obj);
                richTextBox1.WriteLine();
            };



            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");

            // Creates and initializes a new Queue.
            Queue myQueue = new Queue();
            myQueue.Enqueue("jumps");
            myQueue.Enqueue("over");
            myQueue.Enqueue("the");
            myQueue.Enqueue("lazy");
            myQueue.Enqueue("dog");

            // Displays the ArrayList and the Queue.
            richTextBox1.WriteLine("The ArrayList initially contains the following:");
            PrintValues(myAL, '\t');
            richTextBox1.WriteLine("The Queue initially contains the following:");
            PrintValues(myQueue, '\t');

            // Copies the Queue elements to the end of the ArrayList.
            myAL.AddRange(myQueue);

            // Displays the ArrayList.
            richTextBox1.WriteLine("The ArrayList now contains the following:");
            PrintValues(myAL, '\t');
        }

        ///<summary>
        ///
        /// </summary>
        void Test07()
        {
            Action<IEnumerable, char> PrintValues = (myList, mySeparator) =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("{0}{1}", mySeparator, obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");

            // Creates and initializes a new Queue.
            Queue myQueue = new Queue();
            myQueue.Enqueue("jumps");
            myQueue.Enqueue("over");
            myQueue.Enqueue("the");
            myQueue.Enqueue("lazy");
            myQueue.Enqueue("dog");

            // Displays the ArrayList and the Queue.
            richTextBox1.WriteLine("The ArrayList initially contains the following:");
            PrintValues(myAL, '\t');
            richTextBox1.WriteLine("The Queue initially contains the following:");
            PrintValues(myQueue, '\t');

            // Copies the Queue elements to the end of the ArrayList.
            myAL.AddRange(myQueue);

            // Displays the ArrayList.
            richTextBox1.WriteLine("The ArrayList now contains the following:");
            PrintValues(myAL, '\t');
        }

        ///<summary>
        ///
        /// </summary>
        void Test08()
        {
            Action<ArrayList, Object> FindMyObject = (myList, myObject)
             =>
            {
                int myIndex = myList.BinarySearch(myObject);
                if (myIndex < 0)
                    richTextBox1.WriteLine("The object to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex);
                else
                    richTextBox1.WriteLine("The object to search for ({0}) is at index {1}.", myObject, myIndex);
            };
            Action<IEnumerable> PrintValues = (myList)
                =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("   {0}", obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList. BinarySearch requires
            // a sorted ArrayList.
            ArrayList myAL = new ArrayList();
            for (int i = 0; i <= 4; i++)
                myAL.Add(i * 2);

            // Displays the ArrayList.
            richTextBox1.WriteLine("The int ArrayList contains the following:");
            PrintValues(myAL);

            // Locates a specific object that does not exist in the ArrayList.
            Object myObjectOdd = 3;
            FindMyObject(myAL, myObjectOdd);

            // Locates an object that exists in the ArrayList.
            Object myObjectEven = 6;
            FindMyObject(myAL, myObjectEven);
        }

        ///<summary>
        ///
        /// </summary>
        void Test09()
        {
            Action<IEnumerable> PrintValues = (myList)
                =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("   {0}", obj);
                richTextBox1.WriteLine();
            };

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("Initially,");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);

            // Trim the ArrayList.
            myAL.TrimToSize();

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("After TrimToSize,");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);

            // Clear the ArrayList.
            myAL.Clear();

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("After Clear,");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);

            // Trim the ArrayList again.
            myAL.TrimToSize();

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("After the second TrimToSize,");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);
        }

        ///<summary>
        ///
        /// </summary>
        void Test10()
        {
            Action<IEnumerable, char> PrintValues = (myList, mySeparator) =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("{0}{1}", mySeparator, obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes the source ArrayList.
            ArrayList mySourceList = new ArrayList();
            mySourceList.Add("three");
            mySourceList.Add("napping");
            mySourceList.Add("cats");
            mySourceList.Add("in");
            mySourceList.Add("the");
            mySourceList.Add("barn");

            // Creates and initializes the one-dimensional target Array.
            String[] myTargetArray = new String[15];
            myTargetArray[0] = "The";
            myTargetArray[1] = "quick";
            myTargetArray[2] = "brown";
            myTargetArray[3] = "fox";
            myTargetArray[4] = "jumps";
            myTargetArray[5] = "over";
            myTargetArray[6] = "the";
            myTargetArray[7] = "lazy";
            myTargetArray[8] = "dog";

            // Displays the values of the target Array.
            richTextBox1.WriteLine("The target Array contains the following (before and after copying):");
            PrintValues(myTargetArray, ' ');

            // Copies the second element from the source ArrayList to the target Array starting at index 7.
            mySourceList.CopyTo(1, myTargetArray, 7, 1);

            // Displays the values of the target Array.
            PrintValues(myTargetArray, ' ');

            // Copies the entire source ArrayList to the target Array starting at index 6.
            mySourceList.CopyTo(myTargetArray, 6);

            // Displays the values of the target Array.
            PrintValues(myTargetArray, ' ');

            // Copies the entire source ArrayList to the target Array starting at index 0.
            mySourceList.CopyTo(myTargetArray);

            // Displays the values of the target Array.
            PrintValues(myTargetArray, ' ');
        }

        ///<summary>
        ///
        /// </summary>
        void Test11()
        {
            Action<IEnumerable, char> PrintValues = (myList, mySeparator) =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("{0}{1}", mySeparator, obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes the source ArrayList.
            ArrayList mySourceList = new ArrayList();
            mySourceList.Add("three");
            mySourceList.Add("napping");
            mySourceList.Add("cats");
            mySourceList.Add("in");
            mySourceList.Add("the");
            mySourceList.Add("barn");

            // Creates and initializes the one-dimensional target Array.
            String[] myTargetArray = new String[15];
            myTargetArray[0] = "The";
            myTargetArray[1] = "quick";
            myTargetArray[2] = "brown";
            myTargetArray[3] = "fox";
            myTargetArray[4] = "jumps";
            myTargetArray[5] = "over";
            myTargetArray[6] = "the";
            myTargetArray[7] = "lazy";
            myTargetArray[8] = "dog";

            // Displays the values of the target Array.
            richTextBox1.WriteLine("The target Array contains the following (before and after copying):");
            PrintValues(myTargetArray, ' ');

            // Copies the second element from the source ArrayList to the target Array, starting at index 7.
            mySourceList.CopyTo(1, myTargetArray, 7, 1);

            // Displays the values of the target Array.
            PrintValues(myTargetArray, ' ');

            // Copies the entire source ArrayList to the target Array, starting at index 6.
            mySourceList.CopyTo(myTargetArray, 6);

            // Displays the values of the target Array.
            PrintValues(myTargetArray, ' ');

            // Copies the entire source ArrayList to the target Array, starting at index 0.
            mySourceList.CopyTo(myTargetArray);

            // Displays the values of the target Array.
            PrintValues(myTargetArray, ' ');
        }

        ///<summary>
        ///
        /// </summary>
        void Test12()
        {

            Action<IEnumerable, char> PrintValues = (myList, mySeparator) =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("{0}{1}", mySeparator, obj);
                richTextBox1.WriteLine();
            };


            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Create a fixed-size wrapper around the ArrayList.
            ArrayList myFixedSizeAL = ArrayList.FixedSize(myAL);

            // Display whether the ArrayLists have a fixed size or not.
            richTextBox1.WriteLine("myAL {0}.", myAL.IsFixedSize ? "has a fixed size" : "does not have a fixed size");
            richTextBox1.WriteLine("myFixedSizeAL {0}.", myFixedSizeAL.IsFixedSize ? "has a fixed size" : "does not have a fixed size");
            richTextBox1.WriteLine();

            // Display both ArrayLists.
            richTextBox1.WriteLine("Initially,");
            richTextBox1.Write("Standard  :");
            PrintValues(myAL, ' ');
            richTextBox1.Write("Fixed size:");
            PrintValues(myFixedSizeAL, ' ');

            // Sort is allowed in the fixed-size ArrayList.
            myFixedSizeAL.Sort();

            // Display both ArrayLists.
            richTextBox1.WriteLine("After Sort,");
            richTextBox1.Write("Standard  :");
            PrintValues(myAL, ' ');
            richTextBox1.Write("Fixed size:");
            PrintValues(myFixedSizeAL, ' ');

            // Reverse is allowed in the fixed-size ArrayList.
            myFixedSizeAL.Reverse();

            // Display both ArrayLists.
            richTextBox1.WriteLine("After Reverse,");
            richTextBox1.Write("Standard  :");
            PrintValues(myAL, ' ');
            richTextBox1.Write("Fixed size:");
            PrintValues(myFixedSizeAL, ' ');

            // Add an element to the standard ArrayList.
            myAL.Add("AddMe");

            // Display both ArrayLists.
            richTextBox1.WriteLine("After adding to the standard ArrayList,");
            richTextBox1.Write("Standard  :");
            PrintValues(myAL, ' ');
            richTextBox1.Write("Fixed size:");
            PrintValues(myFixedSizeAL, ' ');
            richTextBox1.WriteLine();

            // Adding or inserting elements to the fixed-size ArrayList throws an exception.
            try
            {
                myFixedSizeAL.Add("AddMe2");
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
            try
            {
                myFixedSizeAL.Insert(3, "InsertMe");
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test13()
        {
            ArrayList colors = new ArrayList();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            colors.Add("yellow");
            colors.Add("beige");
            colors.Add("brown");
            colors.Add("magenta");
            colors.Add("purple");

            IEnumerator e = colors.GetEnumerator();
            while (e.MoveNext())
            {
                Object obj = e.Current;
                richTextBox1.WriteLine(obj);
            }

            richTextBox1.WriteLine();

            IEnumerator e2 = colors.GetEnumerator(2, 4);
            while (e2.MoveNext())
            {
                Object obj = e2.Current;
                richTextBox1.WriteLine(obj);
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test14()
        {
            Action<IEnumerable, char> PrintValues = (myList, mySeparator) =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("{0}{1}", mySeparator, obj);
                richTextBox1.WriteLine();
            };


            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Creates and initializes the source ICollection.
            Queue mySourceList = new Queue();
            mySourceList.Enqueue("big");
            mySourceList.Enqueue("gray");
            mySourceList.Enqueue("wolf");

            // Displays the values of five elements starting at index 0.
            ArrayList mySubAL = myAL.GetRange(0, 5);
            richTextBox1.WriteLine("Index 0 through 4 contains:");
            PrintValues(mySubAL, '\t');

            // Replaces the values of five elements starting at index 1 with the values in the ICollection.
            myAL.SetRange(1, mySourceList);

            // Displays the values of five elements starting at index 0.
            mySubAL = myAL.GetRange(0, 5);
            richTextBox1.WriteLine("Index 0 through 4 now contains:");
            PrintValues(mySubAL, '\t');
        }

        ///<summary>
        ///
        /// </summary>
        void Test15()
        {
            Action<IEnumerable> PrintIndexAndValues = (myList)
                =>
            {
                int i = 0;
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   [{0}]:    {1}", i++, obj);
                richTextBox1.WriteLine();
            };

            // Creates and initializes a new ArrayList with three elements of the same value.
            ArrayList myAL = new ArrayList();
            myAL.Add("the");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");
            myAL.Add("in");
            myAL.Add("the");
            myAL.Add("barn");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(myAL);

            // Search for the first occurrence of the duplicated value.
            string myString = "the";
            int myIndex = myAL.IndexOf(myString);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in the last section of the ArrayList.
            myIndex = myAL.IndexOf(myString, 4);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 4 and the end is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in a section of the ArrayList.
            myIndex = myAL.IndexOf(myString, 6, 6);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 6 and index 11 is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in a small section at the end of the ArrayList.
            myIndex = myAL.IndexOf(myString, 11);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 11 and the end is at index {1}.", myString, myIndex);
        }

        ///<summary>
        ///
        /// </summary>
        void Test16()
        {
            Action<IEnumerable> PrintIndexAndValues = (myList)
               =>
            {
                int i = 0;
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   [{0}]:    {1}", i++, obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList with three elements of the same value.
            ArrayList myAL = new ArrayList();
            myAL.Add("the");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");
            myAL.Add("in");
            myAL.Add("the");
            myAL.Add("barn");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(myAL);

            // Search for the first occurrence of the duplicated value.
            string myString = "the";
            int myIndex = myAL.IndexOf(myString);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in the last section of the ArrayList.
            myIndex = myAL.IndexOf(myString, 4);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 4 and the end is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in a section of the ArrayList.
            myIndex = myAL.IndexOf(myString, 6, 6);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 6 and index 11 is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in a small section at the end of the ArrayList.
            myIndex = myAL.IndexOf(myString, 11);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 11 and the end is at index {1}.", myString, myIndex);
        }

        ///<summary>
        ///
        /// </summary>
        void Test17()
        {

            Action<IEnumerable> PrintIndexAndValues = (myList)
                =>
            {
                int i = 0;
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   [{0}]:    {1}", i++, obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList with three elements of the same value.
            ArrayList myAL = new ArrayList();
            myAL.Add("the");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");
            myAL.Add("in");
            myAL.Add("the");
            myAL.Add("barn");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(myAL);

            // Search for the first occurrence of the duplicated value.
            string myString = "the";
            int myIndex = myAL.IndexOf(myString);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in the last section of the ArrayList.
            myIndex = myAL.IndexOf(myString, 4);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 4 and the end is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in a section of the ArrayList.
            myIndex = myAL.IndexOf(myString, 6, 6);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 6 and index 11 is at index {1}.", myString, myIndex);

            // Search for the first occurrence of the duplicated value in a small section at the end of the ArrayList.
            myIndex = myAL.IndexOf(myString, 11);
            richTextBox1.WriteLine("The first occurrence of \"{0}\" between index 11 and the end is at index {1}.", myString, myIndex);
        }
        ///<summary>
        ///
        /// </summary>
        void Test18()
        {
            Action<IEnumerable> PrintValues = (myList)
                =>
            {
                int i = 0;
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   [{0}]:    {1}", i++, obj);
                richTextBox1.WriteLine();
            };


            // Creates and initializes a new ArrayList using Insert instead of Add.
            ArrayList myAL = new ArrayList();
            myAL.Insert(0, "The");
            myAL.Insert(1, "fox");
            myAL.Insert(2, "jumps");
            myAL.Insert(3, "over");
            myAL.Insert(4, "the");
            myAL.Insert(5, "dog");

            // Creates and initializes a new Queue.
            Queue myQueue = new Queue();
            myQueue.Enqueue("quick");
            myQueue.Enqueue("brown");

            // Displays the ArrayList and the Queue.
            richTextBox1.WriteLine("The ArrayList initially contains the following:");
            PrintValues(myAL);
            richTextBox1.WriteLine("The Queue initially contains the following:");
            PrintValues(myQueue);

            // Copies the Queue elements to the ArrayList at index 1.
            myAL.InsertRange(1, myQueue);

            // Displays the ArrayList.
            richTextBox1.WriteLine("After adding the Queue, the ArrayList now contains:");
            PrintValues(myAL);

            // Search for "dog" and add "lazy" before it.
            myAL.Insert(myAL.IndexOf("dog"), "lazy");

            // Displays the ArrayList.
            richTextBox1.WriteLine("After adding \"lazy\", the ArrayList now contains:");
            PrintValues(myAL);

            // Add "!!!" at the end.
            myAL.Insert(myAL.Count, "!!!");

            // Displays the ArrayList.
            richTextBox1.WriteLine("After adding \"!!!\", the ArrayList now contains:");
            PrintValues(myAL);

            // Inserting an element beyond Count throws an exception.
            try
            {
                myAL.Insert(myAL.Count + 1, "anystring");
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test19()
        {
            Action<IEnumerable> PrintIndexAndValues = (myList)
                =>
            {
                int i = 0;
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   [{0}]:    {1}", i++, obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList with three elements of the same value.
            ArrayList myAL = new ArrayList();
            myAL.Add("the");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");
            myAL.Add("in");
            myAL.Add("the");
            myAL.Add("barn");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(myAL);

            // Searches for the last occurrence of the duplicated value.
            string myString = "the";
            int myIndex = myAL.LastIndexOf(myString);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" is at index {1}.", myString, myIndex);

            // Searches for the last occurrence of the duplicated value in the first section of the ArrayList.
            myIndex = myAL.LastIndexOf(myString, 8);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" between the start and index 8 is at index {1}.", myString, myIndex);

            // Searches for the last occurrence of the duplicated value in a section of the ArrayList.  Note that the start index is greater than the end index because the search is done backward.
            myIndex = myAL.LastIndexOf(myString, 10, 6);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" between index 10 and index 5 is at index {1}.", myString, myIndex);
        }

        ///<summary>
        ///
        /// </summary>
        void Test20()
        {
            Action<IEnumerable> PrintIndexAndValues = (myList)
                =>
            {
                int i = 0;
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   [{0}]:    {1}", i++, obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList with three elements of the same value.
            ArrayList myAL = new ArrayList();
            myAL.Add("the");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");
            myAL.Add("in");
            myAL.Add("the");
            myAL.Add("barn");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(myAL);

            // Searches for the last occurrence of the duplicated value.
            string myString = "the";
            int myIndex = myAL.LastIndexOf(myString);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" is at index {1}.", myString, myIndex);

            // Searches for the last occurrence of the duplicated value in the first section of the ArrayList.
            myIndex = myAL.LastIndexOf(myString, 8);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" between the start and index 8 is at index {1}.", myString, myIndex);

            // Searches for the last occurrence of the duplicated value in a section of the ArrayList.  Note that the start index is greater than the end index because the search is done backward.
            myIndex = myAL.LastIndexOf(myString, 10, 6);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" between index 10 and index 5 is at index {1}.", myString, myIndex);
        }


        ///<summary>
        ///
        /// </summary>
        void Test21()
        {
            Action<IEnumerable> PrintIndexAndValues = (myList)
               =>
            {
                int i = 0;
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   [{0}]:    {1}", i++, obj);
                richTextBox1.WriteLine();
            };

            // Creates and initializes a new ArrayList with three elements of the same value.
            ArrayList myAL = new ArrayList();
            myAL.Add("the");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");
            myAL.Add("in");
            myAL.Add("the");
            myAL.Add("barn");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(myAL);

            // Searches for the last occurrence of the duplicated value.
            string myString = "the";
            int myIndex = myAL.LastIndexOf(myString);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" is at index {1}.", myString, myIndex);

            // Searches for the last occurrence of the duplicated value in the first section of the ArrayList.
            myIndex = myAL.LastIndexOf(myString, 8);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" between the start and index 8 is at index {1}.", myString, myIndex);

            // Searches for the last occurrence of the duplicated value in a section of the ArrayList.  Note that the start index is greater than the end index because the search is done backward.
            myIndex = myAL.LastIndexOf(myString, 10, 6);
            richTextBox1.WriteLine("The last occurrence of \"{0}\" between index 10 and index 5 is at index {1}.", myString, myIndex);
        }

        ///<summary>
        ///
        /// </summary>
        void Test22()
        {
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("red");
            myAL.Add("orange");
            myAL.Add("yellow");

            // Creates a read-only copy of the ArrayList.
            ArrayList myReadOnlyAL = ArrayList.ReadOnly(myAL);

            // Displays whether the ArrayList is read-only or writable.
            richTextBox1.WriteLine("myAL is {0}.", myAL.IsReadOnly ? "read-only" : "writable");
            richTextBox1.WriteLine("myReadOnlyAL is {0}.", myReadOnlyAL.IsReadOnly ? "read-only" : "writable");

            // Displays the contents of both collections.
            richTextBox1.WriteLine("\nInitially,");
            richTextBox1.WriteLine("The original ArrayList myAL contains:");
            foreach (string myStr in myAL)
                richTextBox1.WriteLine("   {0}", myStr);
            richTextBox1.WriteLine("The read-only ArrayList myReadOnlyAL contains:");
            foreach (string myStr in myReadOnlyAL)
                richTextBox1.WriteLine("   {0}", myStr);

            // Adding an element to a read-only ArrayList throws an exception.
            richTextBox1.WriteLine("\nTrying to add a new element to the read-only ArrayList:");
            try
            {
                myReadOnlyAL.Add("green");
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }

            // Adding an element to the original ArrayList affects the read-only ArrayList.
            myAL.Add("blue");

            // Displays the contents of both collections again.
            richTextBox1.WriteLine("\nAfter adding a new element to the original ArrayList,");
            richTextBox1.WriteLine("The original ArrayList myAL contains:");
            foreach (string myStr in myAL)
                richTextBox1.WriteLine("   {0}", myStr);
            richTextBox1.WriteLine("The read-only ArrayList myReadOnlyAL contains:");
            foreach (string myStr in myReadOnlyAL)
                richTextBox1.WriteLine("   {0}", myStr);
        }

        ///<summary>
        ///
        /// </summary>
        void Test23()
        {
            Action<IEnumerable> PrintValues = (myList)
                =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("   {0}", obj);
                richTextBox1.WriteLine();
            };

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Displays the ArrayList.
            richTextBox1.WriteLine("The ArrayList initially contains the following:");
            PrintValues(myAL);

            // Removes the element containing "lazy".
            myAL.Remove("lazy");

            // Displays the current state of the ArrayList.
            richTextBox1.WriteLine("After removing \"lazy\":");
            PrintValues(myAL);

            // Removes the element at index 5.
            myAL.RemoveAt(5);

            // Displays the current state of the ArrayList.
            richTextBox1.WriteLine("After removing the element at index 5:");
            PrintValues(myAL);

            // Removes three elements starting at index 4.
            myAL.RemoveRange(4, 3);

            // Displays the current state of the ArrayList.
            richTextBox1.WriteLine("After removing three elements starting at index 4:");
            PrintValues(myAL);
        }

        ///<summary>
        ///
        /// </summary>
        void Test24()
        {

            Action<IEnumerable> PrintValues = (myList)
                =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("   {0}", obj);
                richTextBox1.WriteLine();
            };


            // Creates a new ArrayList with five elements and initialize each element with a null value.
            ArrayList myAL = ArrayList.Repeat(null, 5);

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("ArrayList with five elements with a null value");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);

            // Creates a new ArrayList with seven elements and initialize each element with the string "abc".
            myAL = ArrayList.Repeat("abc", 7);

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("ArrayList with seven elements with a string value");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);
        }

        ///<summary>
        ///
        /// </summary>
        void Test25()
        {
            Action<IEnumerable> PrintValues = (myList)
                =>
            {
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   {0}", obj);
                richTextBox1.WriteLine();
            };

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList initially contains the following values:");
            PrintValues(myAL);

            // Reverses the sort order of the values of the ArrayList.
            myAL.Reverse();

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("After reversing:");
            PrintValues(myAL);
        }

        ///<summary>
        ///
        /// </summary>
        void Test26()
        {
            Action<IEnumerable, char> PrintValues = (myList, mySeparator)
               =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("{0}{1}", mySeparator, obj);
                richTextBox1.WriteLine();
            };

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Creates and initializes the source ICollection.
            Queue mySourceList = new Queue();
            mySourceList.Enqueue("big");
            mySourceList.Enqueue("gray");
            mySourceList.Enqueue("wolf");

            // Displays the values of five elements starting at index 0.
            ArrayList mySubAL = myAL.GetRange(0, 5);
            richTextBox1.WriteLine("Index 0 through 4 contains:");
            PrintValues(mySubAL, '\t');

            // Replaces the values of five elements starting at index 1 with the values in the ICollection.
            myAL.SetRange(1, mySourceList);

            // Displays the values of five elements starting at index 0.
            mySubAL = myAL.GetRange(0, 5);
            richTextBox1.WriteLine("Index 0 through 4 now contains:");
            PrintValues(mySubAL, '\t');
        }

        ///<summary>
        ///
        /// </summary>
        void Test27()
        {
            Action<IEnumerable> PrintValues = (myList)
               =>
            {
                foreach (Object obj in myList)
                    richTextBox1.WriteLine("   {0}", obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList initially contains the following values:");
            PrintValues(myAL);

            // Sorts the values of the ArrayList.
            myAL.Sort();

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("After sorting:");
            PrintValues(myAL);
        }

        ///<summary>
        ///
        /// </summary>
        void Test28()
        {

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");

            // Creates a synchronized wrapper around the ArrayList.
            ArrayList mySyncdAL = ArrayList.Synchronized(myAL);

            // Displays the sychronization status of both ArrayLists.
            richTextBox1.WriteLine("myAL is {0}.", myAL.IsSynchronized ? "synchronized" : "not synchronized");
            richTextBox1.WriteLine("mySyncdAL is {0}.", mySyncdAL.IsSynchronized ? "synchronized" : "not synchronized");
        }

        ///<summary>
        ///
        /// </summary>
        void Test29()
        {
            Action<IEnumerable> PrintIndexAndValues = (myList) =>
            {
                int i = 0;
                foreach (Object o in myList)
                    richTextBox1.WriteLine("\t[{0}]:\t{1}", i++, o);
                richTextBox1.WriteLine();
            };
            Action<string[]> _PrintIndexAndValues = (myArr) =>
            {
                for (int i = 0; i < myArr.Length; i++)
                    richTextBox1.WriteLine("\t[{0}]:\t{1}", i, myArr[i]);
                richTextBox1.WriteLine();
            };


            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Displays the values of the ArrayList.
            richTextBox1.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(myAL);

            // Copies the elements of the ArrayList to a string array.
            String[] _myArr = (String[])myAL.ToArray(typeof(string));

            // Displays the contents of the string array.
            richTextBox1.WriteLine("The string array contains the following values:");
            _PrintIndexAndValues(_myArr);
        }

        ///<summary>
        ///
        /// </summary>
        void Test30()
        {

            Action<IEnumerable> PrintValues = (myList) =>
            {
                foreach (Object obj in myList)
                    richTextBox1.Write("   {0}", obj);
                richTextBox1.WriteLine();
            };
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("Initially,");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);

            // Trim the ArrayList.
            myAL.TrimToSize();

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("After TrimToSize,");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);

            // Clear the ArrayList.
            myAL.Clear();

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("After Clear,");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);

            // Trim the ArrayList again.
            myAL.TrimToSize();

            // Displays the count, capacity and values of the ArrayList.
            richTextBox1.WriteLine("After the second TrimToSize,");
            richTextBox1.WriteLine("   Count    : {0}", myAL.Count);
            richTextBox1.WriteLine("   Capacity : {0}", myAL.Capacity);
            richTextBox1.Write("   Values:");
            PrintValues(myAL);
        }

        ///<summary>
        ///
        /// </summary>
        void Test31()
        {
            Action<IEnumerable, int> PrintValues = (myList, myWidth) =>
            {
                int i = myWidth;
                foreach (Object obj in myList)
                {
                    if (i <= 0)
                    {
                        i = myWidth;
                        richTextBox1.WriteLine();
                    }
                    i--;
                    richTextBox1.Write("{0,8}", obj);
                }
                richTextBox1.WriteLine();
            };

            // Creates and initializes several BitArrays.
            BitArray myBA1 = new BitArray(5);

            BitArray myBA2 = new BitArray(5, false);

            byte[] myBytes = new byte[5] { 1, 2, 3, 4, 5 };
            BitArray myBA3 = new BitArray(myBytes);

            bool[] myBools = new bool[5] { true, false, true, true, false };
            BitArray myBA4 = new BitArray(myBools);

            int[] myInts = new int[5] { 6, 7, 8, 9, 10 };
            BitArray myBA5 = new BitArray(myInts);

            // Displays the properties and values of the BitArrays.
            richTextBox1.WriteLine("myBA1");
            richTextBox1.WriteLine("   Count:    {0}", myBA1.Count);
            richTextBox1.WriteLine("   Length:   {0}", myBA1.Length);
            richTextBox1.WriteLine("   Values:");
            PrintValues(myBA1, 8);

            richTextBox1.WriteLine("myBA2");
            richTextBox1.WriteLine("   Count:    {0}", myBA2.Count);
            richTextBox1.WriteLine("   Length:   {0}", myBA2.Length);
            richTextBox1.WriteLine("   Values:");
            PrintValues(myBA2, 8);

            richTextBox1.WriteLine("myBA3");
            richTextBox1.WriteLine("   Count:    {0}", myBA3.Count);
            richTextBox1.WriteLine("   Length:   {0}", myBA3.Length);
            richTextBox1.WriteLine("   Values:");
            PrintValues(myBA3, 8);

            richTextBox1.WriteLine("myBA4");
            richTextBox1.WriteLine("   Count:    {0}", myBA4.Count);
            richTextBox1.WriteLine("   Length:   {0}", myBA4.Length);
            richTextBox1.WriteLine("   Values:");
            PrintValues(myBA4, 8);

            richTextBox1.WriteLine("myBA5");
            richTextBox1.WriteLine("   Count:    {0}", myBA5.Count);
            richTextBox1.WriteLine("   Length:   {0}", myBA5.Length);
            richTextBox1.WriteLine("   Values:");
            PrintValues(myBA5, 8);

        }

        ///<summary>
        ///
        /// </summary>
        void Test32()
        {

            Action<IEnumerable, int> PrintValues = (myList, myWidth) =>
            {
                int i = myWidth;
                foreach (Object obj in myList)
                {
                    if (i <= 0)
                    {
                        i = myWidth;
                        richTextBox1.WriteLine();
                    }
                    i--;
                    richTextBox1.Write("{0,8}", obj);
                }
                richTextBox1.WriteLine();
            };
            // Creates and initializes two BitArrays of the same size.
            BitArray myBA1 = new BitArray(4);
            BitArray myBA2 = new BitArray(4);
            myBA1[0] = myBA1[1] = false;
            myBA1[2] = myBA1[3] = true;
            myBA2[0] = myBA2[2] = false;
            myBA2[1] = myBA2[3] = true;

            // Performs a bitwise AND operation between BitArray instances of the same size.
            richTextBox1.WriteLine("Initial values");
            richTextBox1.Write("myBA1:");
            PrintValues(myBA1, 8);
            richTextBox1.Write("myBA2:");
            PrintValues(myBA2, 8);
            richTextBox1.WriteLine();

            richTextBox1.WriteLine("Result");
            richTextBox1.Write("AND:");
            PrintValues(myBA1.And(myBA2), 8);
            richTextBox1.WriteLine();

            richTextBox1.WriteLine("After AND");
            richTextBox1.Write("myBA1:");
            PrintValues(myBA1, 8);
            richTextBox1.Write("myBA2:");
            PrintValues(myBA2, 8);
            richTextBox1.WriteLine();

            // Performing AND between BitArray instances of different sizes returns an exception.
            try
            {
                BitArray myBA3 = new BitArray(8);
                myBA3[0] = myBA3[1] = myBA3[2] = myBA3[3] = false;
                myBA3[4] = myBA3[5] = myBA3[6] = myBA3[7] = true;
                myBA1.And(myBA3);
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test33()
        {
            Action<IEnumerable> PrintValues = (myArr) =>
            {
                foreach (Object obj in myArr)
                {
                    richTextBox1.Write("{0,8}", obj);
                }
                richTextBox1.WriteLine();
            };

            // Creates and initializes the source BitArray.
            BitArray myBA = new BitArray(4);
            myBA[0] = myBA[1] = myBA[2] = myBA[3] = true;

            // Creates and initializes the one-dimensional target Array of type Boolean.
            bool[] myBoolArray = new bool[8];
            myBoolArray[0] = false;
            myBoolArray[1] = false;

            // Displays the values of the target Array.
            richTextBox1.WriteLine("The target Boolean Array contains the following (before and after copying):");
            PrintValues(myBoolArray);

            // Copies the entire source BitArray to the target BitArray, starting at index 3.
            myBA.CopyTo(myBoolArray, 3);

            // Displays the values of the target Array.
            PrintValues(myBoolArray);

            // Creates and initializes the one-dimensional target Array of type integer.
            int[] myIntArray = new int[8];
            myIntArray[0] = 42;
            myIntArray[1] = 43;

            // Displays the values of the target Array.
            richTextBox1.WriteLine("The target integer Array contains the following (before and after copying):");
            PrintValues(myIntArray);

            // Copies the entire source BitArray to the target BitArray, starting at index 3.
            myBA.CopyTo(myIntArray, 3);

            // Displays the values of the target Array.
            PrintValues(myIntArray);

            // Creates and initializes the one-dimensional target Array of type byte.
            Array myByteArray = Array.CreateInstance(typeof(byte), 8);
            myByteArray.SetValue((byte)10, 0);
            myByteArray.SetValue((byte)11, 1);

            // Displays the values of the target Array.
            richTextBox1.WriteLine("The target byte Array contains the following (before and after copying):");
            PrintValues(myByteArray);

            // Copies the entire source BitArray to the target BitArray, starting at index 3.
            myBA.CopyTo(myByteArray, 3);

            // Displays the values of the target Array.
            PrintValues(myByteArray);

            // Returns an exception if the array is not of type Boolean, integer or byte.
            try
            {
                Array myStringArray = Array.CreateInstance(typeof(string), 8);
                myStringArray.SetValue("Hello", 0);
                myStringArray.SetValue("World", 1);
                myBA.CopyTo(myStringArray, 3);
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test34()
        {
            Action<IEnumerable> PrintIndexAndValues = (myCol) =>
            {
                int i = 0;
                foreach (Object obj in myCol)
                {
                    richTextBox1.WriteLine("    [{0}]:    {1}", i++, obj);
                }
                richTextBox1.WriteLine();
            };
            // Creates and initializes a BitArray.
            BitArray myBA = new BitArray(5);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("myBA values:");
            PrintIndexAndValues(myBA);

            // Sets all the elements to true.
            myBA.SetAll(true);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("After setting all elements to true,");
            PrintIndexAndValues(myBA);

            // Sets the last index to false.
            myBA.Set(myBA.Count - 1, false);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("After setting the last element to false,");
            PrintIndexAndValues(myBA);

            // Gets the value of the last two elements.
            richTextBox1.WriteLine("The last two elements are: ");
            richTextBox1.WriteLine("    at index {0} : {1}", myBA.Count - 2, myBA.Get(myBA.Count - 2));
            richTextBox1.WriteLine("    at index {0} : {1}", myBA.Count - 1, myBA.Get(myBA.Count - 1));
        }

        ///<summary>
        ///
        /// </summary>
        void Test35()
        {

            Action<IEnumerable, int> PrintValues = (myList, myWidth) =>
            {
                int i = myWidth;
                foreach (Object obj in myList)
                {
                    if (i <= 0)
                    {
                        i = myWidth;
                        richTextBox1.WriteLine();
                    }
                    i--;
                    richTextBox1.Write("{0,8}", obj);
                }
                richTextBox1.WriteLine();
            };
            // Creates and initializes two BitArrays of the same size.
            BitArray myBA1 = new BitArray(4);
            BitArray myBA2 = new BitArray(4);
            myBA1[0] = myBA1[1] = false;
            myBA1[2] = myBA1[3] = true;
            myBA2[0] = myBA2[2] = false;
            myBA2[1] = myBA2[3] = true;

            // Performs a bitwise NOT operation between BitArray instances of the same size.
            richTextBox1.WriteLine("Initial values");
            richTextBox1.Write("myBA1:");
            PrintValues(myBA1, 8);
            richTextBox1.Write("myBA2:");
            PrintValues(myBA2, 8);
            richTextBox1.WriteLine();

            myBA1.Not();
            myBA2.Not();

            richTextBox1.WriteLine("After NOT");
            richTextBox1.Write("myBA1:");
            PrintValues(myBA1, 8);
            richTextBox1.Write("myBA2:");
            PrintValues(myBA2, 8);
            richTextBox1.WriteLine();
        }

        ///<summary>
        ///
        /// </summary>
        void Test36()
        {
            Action<IEnumerable, int> PrintValues = (myList, myWidth) =>
            {
                int i = myWidth;
                foreach (object obj in myList)
                {
                    if (i <= 0)
                    {
                        i = myWidth;
                        richTextBox1.WriteLine();
                    }
                    i--;
                    richTextBox1.Write("{0,8}", obj);
                }
                richTextBox1.WriteLine();
            };
            // Creates and initializes two BitArrays of the same size.
            BitArray myBA1 = new BitArray(4);
            BitArray myBA2 = new BitArray(4);
            myBA1[0] = myBA1[1] = false;
            myBA1[2] = myBA1[3] = true;
            myBA2[0] = myBA2[2] = false;
            myBA2[1] = myBA2[3] = true;

            // Performs a bitwise OR operation between BitArray instances of the same size.
            richTextBox1.WriteLine("Initial values");
            richTextBox1.Write("myBA1:");
            PrintValues(myBA1, 8);
            richTextBox1.Write("myBA2:");
            PrintValues(myBA2, 8);
            richTextBox1.WriteLine();

            richTextBox1.WriteLine("Result");
            richTextBox1.Write("OR:");
            PrintValues(myBA1.Or(myBA2), 8);
            richTextBox1.WriteLine();

            richTextBox1.WriteLine("After OR");
            richTextBox1.Write("myBA1:");
            PrintValues(myBA1, 8);
            richTextBox1.Write("myBA2:");
            PrintValues(myBA2, 8);
            richTextBox1.WriteLine();

            // Performing OR between BitArray instances of different sizes returns an exception.
            try
            {
                BitArray myBA3 = new BitArray(8);
                myBA3[0] = myBA3[1] = myBA3[2] = myBA3[3] = false;
                myBA3[4] = myBA3[5] = myBA3[6] = myBA3[7] = true;
                myBA1.Or(myBA3);
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test37()
        {
            Action<IEnumerable> PrintIndexAndValues = myCol =>
            {
                int i = 0;
                foreach (object obj in myCol)
                {
                    richTextBox1.WriteLine("    [{0}]:    {1}", i++, obj);
                }
                richTextBox1.WriteLine();
            };

            // Creates and initializes a BitArray.
            BitArray myBA = new BitArray(5);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("myBA values:");
            PrintIndexAndValues(myBA);

            // Sets all the elements to true.
            myBA.SetAll(true);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("After setting all elements to true,");
            PrintIndexAndValues(myBA);

            // Sets the last index to false.
            myBA.Set(myBA.Count - 1, false);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("After setting the last element to false,");
            PrintIndexAndValues(myBA);

            // Gets the value of the last two elements.
            richTextBox1.WriteLine("The last two elements are: ");
            richTextBox1.WriteLine("    at index {0} : {1}", myBA.Count - 2, myBA.Get(myBA.Count - 2));
            richTextBox1.WriteLine("    at index {0} : {1}", myBA.Count - 1, myBA.Get(myBA.Count - 1));
        }

        ///<summary>
        ///
        /// </summary>
        void Test38()
        {
            Action<IEnumerable> PrintIndexAndValues = (myCol) =>
            {
                int i = 0;
                foreach (Object obj in myCol)
                {
                    richTextBox1.WriteLine("    [{0}]:    {1}", i++, obj);
                }
                richTextBox1.WriteLine();
            };
            // Creates and initializes a BitArray.
            BitArray myBA = new BitArray(5);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("myBA values:");
            PrintIndexAndValues(myBA);

            // Sets all the elements to true.
            myBA.SetAll(true);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("After setting all elements to true,");
            PrintIndexAndValues(myBA);

            // Sets the last index to false.
            myBA.Set(myBA.Count - 1, false);

            // Displays the properties and values of the BitArray.
            richTextBox1.WriteLine("After setting the last element to false,");
            PrintIndexAndValues(myBA);

            // Gets the value of the last two elements.
            richTextBox1.WriteLine("The last two elements are: ");
            richTextBox1.WriteLine("    at index {0} : {1}", myBA.Count - 2, myBA.Get(myBA.Count - 2));
            richTextBox1.WriteLine("    at index {0} : {1}", myBA.Count - 1, myBA.Get(myBA.Count - 1));
        }

        ///<summary>
        ///
        /// </summary>
        void Test39()
        {
            Action<IEnumerable, int> PrintValues = (myList, myWidth) =>
            {
                int i = myWidth;
                foreach (Object obj in myList)
                {
                    if (i <= 0)
                    {
                        i = myWidth;
                        richTextBox1.WriteLine();
                    }
                    i--;
                    richTextBox1.Write("{0,8}", obj);
                }
                richTextBox1.WriteLine();
            };

            // Creates and initializes two BitArrays of the same size.
            BitArray myBA1 = new BitArray(4);
            BitArray myBA2 = new BitArray(4);
            myBA1[0] = myBA1[1] = false;
            myBA1[2] = myBA1[3] = true;
            myBA2[0] = myBA2[2] = false;
            myBA2[1] = myBA2[3] = true;

            // Performs a bitwise XOR operation between BitArray instances of the same size.
            richTextBox1.WriteLine("Initial values");
            richTextBox1.Write("myBA1:");
            PrintValues(myBA1, 8);
            richTextBox1.Write("myBA2:");
            PrintValues(myBA2, 8);
            richTextBox1.WriteLine();

            richTextBox1.WriteLine("Result");
            richTextBox1.Write("XOR:");
            PrintValues(myBA1.Xor(myBA2), 8);
            richTextBox1.WriteLine();

            richTextBox1.WriteLine("After XOR");
            richTextBox1.Write("myBA1:");
            PrintValues(myBA1, 8);
            richTextBox1.Write("myBA2:");
            PrintValues(myBA2, 8);
            richTextBox1.WriteLine();

            // Performing XOR between BitArray instances of different sizes returns an exception.
            try
            {
                BitArray myBA3 = new BitArray(8);
                myBA3[0] = myBA3[1] = myBA3[2] = myBA3[3] = false;
                myBA3[4] = myBA3[5] = myBA3[6] = myBA3[7] = true;
                myBA1.Xor(myBA3);
            }
            catch (Exception myException)
            {
                richTextBox1.WriteLine("Exception: " + myException.ToString());
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test40()
        {
            // Create a Hashtable using the default hash code provider and the default comparer.
            Hashtable myHT1 = new Hashtable();
            myHT1.Add("FIRST", "Hello");
            myHT1.Add("SECOND", "World");
            myHT1.Add("THIRD", "!");

            // Create a Hashtable using a case-insensitive code provider and a case-insensitive comparer,
            // based on the culture of the current thread.
            Hashtable myHT2 = new Hashtable(new CaseInsensitiveHashCodeProvider(), new CaseInsensitiveComparer());
            myHT2.Add("FIRST", "Hello");
            myHT2.Add("SECOND", "World");
            myHT2.Add("THIRD", "!");

            // Create a Hashtable using a case-insensitive code provider and a case-insensitive comparer,
            // based on the InvariantCulture.
            Hashtable myHT3 = new Hashtable(CaseInsensitiveHashCodeProvider.DefaultInvariant, CaseInsensitiveComparer.DefaultInvariant);
            myHT3.Add("FIRST", "Hello");
            myHT3.Add("SECOND", "World");
            myHT3.Add("THIRD", "!");

            // Create a Hashtable using a case-insensitive code provider and a case-insensitive comparer,
            // based on the Turkish culture (tr-TR), where "I" is not the uppercase version of "i".
            CultureInfo myCul = new CultureInfo("tr-TR");
            Hashtable myHT4 = new Hashtable(new CaseInsensitiveHashCodeProvider(myCul), new CaseInsensitiveComparer(myCul));
            myHT4.Add("FIRST", "Hello");
            myHT4.Add("SECOND", "World");
            myHT4.Add("THIRD", "!");

            // Search for a key in each hashtable.
            richTextBox1.WriteLine("first is in myHT1: {0}", myHT1.ContainsKey("first"));
            richTextBox1.WriteLine("first is in myHT2: {0}", myHT2.ContainsKey("first"));
            richTextBox1.WriteLine("first is in myHT3: {0}", myHT3.ContainsKey("first"));
            richTextBox1.WriteLine("first is in myHT4: {0}", myHT4.ContainsKey("first"));
        }

        ///<summary>
        ///
        /// </summary>
        void Test41()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test42()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test43()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test44()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test45()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test46()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test47()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test48()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test49()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test50()
        {

        }

        private void InitializeComponent()
        {

        }

  
    }
}
