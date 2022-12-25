using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datastructures{

    class Datastructures{


        #region Stack using Arrays

        //first we declare a class of Stack
        class Stack{

            //LIFO datastructure

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

        /*limittions of arrays
        all data stored must be of same type;
        must have a fixed size;cant be changed later;
        stores data sequentially inmemory

        linkedlist--
        each element is a node; flexible size;
        no need for sequential arrangement;

        whenever we use the = operator and direct it at an object...we are only rfferring/assigining to the value of the memroy address of that class instance...this is how we refer to the next node...howvere...the same operator can be used to assign default vlaues of integer,etc datatypes...

        each node is a unique object;

        first node is Head, last node is Tail;

        we dont mainupulate head-refernce otherwise the list is corrupted



        */

        //Nodes of linked list--
        //contais the data along with memory address for next node...

          


        



        #endregion

        #region circular Linkd List

        #endregion

        #region doubly linked list

        #endregion


        #region Queues using arrays

        class Queue{

            //FIFO datatsructure
            
            int[] data;//storage for the elements

            int front;//index of the element at the orint of teh queue
            int rear;//index of the element at the bck of the queue
            int size;//total size of the queue.





            public Queue(int n){

                data = new int[n];//capacity o the queue
                front=0;//because so far the queue is emty
                size=0;
                rear=0;
                


            }

            public int dequeue(){
                //removes  and returns the element from the front end of the queue
                if(isEmpty()){
                    Console.WriteLine("is empty");
                    return -1;//retun 0 means that the program succeded and we are exiting the program...return -1 means that there has been an error

                }
                else{
                    int e=data[front];
                    front=front+1;
                    size=size-1;
                    return e;

                }


            }
            public bool isFull(){
                return size==data.Length;
            }

            public void enqueue(int e){
                //inserts  and returns a new element from the rear end of the queue
                if(isFull()){
                    Console.WriteLine("no space ");
                    return;
                    //significnce of the return statement--
                    //calling function is the function where te function passes the values to the function paramaetrs that is teh arguements inorder t get a desired result...in the main function declaration, the presence of the return expression is a way of saying that "here is the code execution and the we have ound the result ofthe calculation which we want to pass to the calling function...", OR simply pass the control bac to the calling function, this way, we can execute the functionbased onany value and that will everytime refer to the main function declaration which will then return the control back to each time the calling funtion with different arguements gets executed, with new values from execution/implementation based on the value of the function parameter, that is the aruement being passed by the calling functions...

                }
                else{
                    //must always close with else...conditonals are left without this..error will be shown if other conditions are possible;
                    data[rear]=e;
                    rear=rear+1;//the old rear index vlue must change to make way for new rear int
                    size=size+1;//inreasing the overall space


                }

            }

            public void first(){
                //returns the element that is in athe front f the queue, without removina the eelement from front unlike dequeue

            }

            public void display(){
                for(int i =front;i<rear;i++){
                    Console.WriteLine(data[i]);
                }
            }

            public bool isEmpty(){
                //here in such cases we cannot just use the if statement and leave it hanging...the compiler logic is not always same as human logic...so when we use the if loop, if we dont pass the other coiditionals like else and else if...then the compiler will take is an error because technically we are leaving the other eventualities un-addressed...thus its better to use all other consitionals or pass a return satement outside of the conditionals...thus following imlememntation is wrong
                // if(data.Length==0){
                //     return "true";
                // }
                //use this instead...
                return size == 0;//that is is size is zero...it retruns true



            }

            public int len(){
                //find out the length of the queue
                return size;//number of elements in queue 

            }
        }




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
            Queue que = new Queue(10);
            que.enqueue(3);
            que.enqueue(5);
            Console.WriteLine(que.len());
            que.display();



        }
    }

    

   


    







}

