using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datastructures{

    class Datastructures{


        #region Stack using Arrays

        //first we declare a class of Stack
        class Stack{

            //then, we need the default parameeters of the class
            int[] data;//where the data will be stored, can be generic as well
            int top;//this shows the size of the data storage

            public Stack(int n){

                data=new int[n]; //instantiating a datatstorage of array type of size n
                top=0; //storage with 0 values.


            }

            public int length(){
                return top;
            }

            public bool isEmpty(){
                return top==0;
            }

            public bool isFull(){
                return top==data.Length;
            }

            public void push(int e){
                if(isFull()){
                    Console.WriteLine("its full");
                    return;
                }
                else{
                    data[top]=e;
                    top=top + 1;
                }
            }

            public int pop(){
                if(isEmpty()){
                    Console.WriteLine("its empty");
                    return -1;
                }
                else{
                    top -= 1;
                    return data[top-1];
                }
            }

            public int peek(){
                //only shws the eement insted of removing it frm data like pop()
                if(isEmpty()){
                    Console.WriteLine("is empty");
                    return -1;
                }
                else{
                    return data[top-1];
                }



            }

            public void display(){
                for(int i=0;i<top;i++){
                    Console.WriteLine("the element"+ i + "is --"+ data[i]);



                }
            }




        }



        

        #endregion

        #region Stack using Linkedlist




        #endregion


        #region Linkedlist

        #endregion


        #region Queues using arrays




        #endregion

        #region Queues using linked lists

        #endregion







        public static void Main(string[] args){
            Console.WriteLine("Stack datastructure -- using arrays ");
            Stack stack = new Stack(10);
            stack.push(5);
            stack.push(9);
            stack.display();
            Console.WriteLine("size is -- " + stack.length());



        }
    }

    

   


    







}

