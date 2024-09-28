using System;
using TODOlistapplication;

public static class Class1
{

    static List<UserTask> TaskList = new List<UserTask>();
    public static void AddTask(string Task, DateTime dateDone, string Status)
    {
        TaskList.Add(new(Task, dateDone, Status));
    }

    public static List<UserTask> Gettask()
    {
        return TaskList;
    }

    public static void MarkTaskAsDone(int index)
    {
            TaskList[index].status = "done";
            TaskList[index].dateDone = DateTime.Now;
    }
}


