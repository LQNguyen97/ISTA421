# Linh Nguyen
## C# Homework 23

1 List two reasons for multitasking, and explain the rationale for them.

	A multitasking operating system divides the available processor time among the processes or threads that need it. The system is designed for preemptive multitasking; it allocates a processor time slice to each thread it executes.
	To Improve responsiveness and to improve scalability.
	
	improve scalability and responsiveness 2 Explain Moore's law. What does Moore's law have to do with multitasking?
	
	Moore’s Law states that every 18 months a CPU’s transistors will shrink in size by a factor of two. This means every 18 months you can stuff twice as many transistors onto a CPU, making it twice as fast.

2 Explain Moore’s law. What does Moore’s law have to do with multitasking?

	Moore’s law states that companies that produce chips will be able to keep packingmore and more transistors closer together every two years. This means thatmultitasking will be more applicable because more resources will be able to be usedwith faster times 

3 In UWP, what namespace is used as the container for the multitasking methods?

	System.Threading.Thread

4 What is the difference between tasks and threads? Explain.

	A task is something you want done. A thread is one of the many possible workers which performs that task.
	Task is an abstraction and a thread is an execution that you send to the processor. 

5 What is the ThreadPool?

	threadpool is a cross-platform C++ thread pool library. In general terms thread pools are an efficient mechanism for asynchronous task processing within the same process.

6 What parameters does the Task() constructor take?

	Task Constructor (Action,Object)

7 How do you start a thread?

	Thread t = new Thread(new ParameterizedThreadStart(StartupA)); t.Start(new MyThreadParams(path, port));

8 What is the difference between the Start() and Run() methods?

	start() enable the Thread to be controlled in states. Explicity invoking run() , violates the flow and state of a Thread execution. start() is not invoked for the main method thread or "system" or group threads created/set up by the VM. Any new functionality added to this method in the future may have to also be added to the VM.

9 What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel? Explain.

	Tasks parallelization: You have complete control over the number of tasks your application creates. 
	Parallel: Programming constructs without having to redesign an application. Creates its own set of Task object. 

10 Explain how manual cancellation works using a cancellation token.

	A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects. You create a cancellation token by instantiating a CancellationTokenSource object, which manages cancellation tokens retrieved from its CancellationTokenSource.Token property. You then pass the cancellation token to any number of threads, tasks, or operations that should receive notice of cancellation.