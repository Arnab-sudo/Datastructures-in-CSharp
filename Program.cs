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

        public class Node{
            public int element;
            public Node next; //creating a node instance that will be he next node in the list;
            public Node(int e, Node n){
                //constructor for Node class
                element = e;//value of the Node;
                next=n;//next which is  a object type of Node(as declared in the class) is  referring to the forward node n(as will be declred by class instaces that is, objects);


             

            }
        }

        class LinkedList{

            private Node? head;//first node in the linked list;we make these object nodes nullable so that they can refer to null vlaues while being value types.
            private Node? tail;//last node in the list;
            private int size;

            public LinkedList(){

                //initially the list will be empty
                //so
                head=null;
                tail=null;
                size=0;


            }

            //Methods

            public int length(){
                return size;
            }

            public bool isEmpty(){
                return size==0;
            }

            public void addlast(int e){
                Node newest = new Node(e,null);//because the new node doesnt poin t any other node, given that is the new last node;
                if(isEmpty()){
                    head=newest;

                }
                else{
                    if(tail!=null){
                        //we need to check if tail node is null or not because tail is a nullable type thjat can refer to a null vlaue, which otherwise will throw an exception though the code will run,,,its just safer this way
                        tail.next=newest;

                    }
                    
                }
                tail=newest;
                size=size+1;

            }

              
            //inserting node/element at te top of the list
            public void addfirst(int e){
                Node newest = new Node(e, null);
                if(isEmpty()){
                    head=newest;
                    tail=newest;
                }
                else{
                    if(head!=null){
                        newest.next = head;
                        head=newest;

                    }
                    size=size+1;
                    
                }
            }

            //inserting an element/node anywhere in the middle of he list
            public void adddany(int e, int position){
                if(position<=0||position>=size){
                    Console.WriteLine("invalid");
                    return;
                    //point to be noted--
                    /*The return statement can be skipped only for void types. Not using return statement in void return type function: When a function does not return anything, the void return type is used. So if there is a void return type in the function definition, then there will be no return statement inside that function (generally)*/
                }
                Node newest = new Node(e, null);//declaring variables with same namesin different methods isokay because under OOPS the scope of the variables are different;
                Node? p = head;
                int i = 1;
                while(i<position-1){//while loop best suited because it requires iterations
                    if(p!=null){
                        p=p.next;

                    }
                    i=i+1;



                }
                if(newest!=null && p!=null){
                    //in this case, running a while lop is a bad idea becaus eth condition is true all the time, there is no xit to the ocndtions which is why the code will run nfinetly...thus if loop is best as it doesnt require iterative calculations;
                    newest.next=p.next;
                    p.next=newest;
                }
                size=size+1;



            }

            //deleting at the beginning of the linked list
            public int removefirst(){

                if(isEmpty()){
                    return -1;
                }
                else{
                    if(head!=null){
                        int e = head.element;
                        head=head.next;
                        return e;
                        



                    }
                    
                    size=size-1;
                    if(isEmpty()){
                        tail=null;
                       

                    }
                    return 1;
                    //always close a if else block with a return statement unless yu want to get an erro saying that not all code paths return a variable; 
                    //return 1 means that the functionreturn true boolean value; return 0 wud have meant tha the functionwas returning false value.                 
                    
                }



            }

            public int removelast(){
                if(isEmpty()){
                    return -1;
                }
                Node? p = head;
                
                
                return 1;
            }


          



            public void display(){
                Node? p=head;
                while(p!=null){
                    Console.WriteLine(p.element);
                    p=p.next;
                }
                Console.WriteLine();
            }


        }



          


        



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
            LinkedList link=new LinkedList();
            link.addlast(7);
            link.addlast(4);
            link.addlast(12);
            link.display();
            link.addfirst(15);
            link.adddany(20,3);
            link.removefirst();
            link.display();
            Console.WriteLine(link.isEmpty());




        }
    }

    

   


    







}

