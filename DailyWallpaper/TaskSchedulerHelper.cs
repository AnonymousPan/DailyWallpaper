using System;
using System.Collections.Generic;
using System.Linq;
using TaskScheduler;

namespace DailyWallpaper
{
    public static class TaskSchedulerHelper
    {
        private static TaskSchedulerClass ts = new TaskSchedulerClass();
        private static ITaskFolder folder;

        public static void Init()
        {
            ts.Connect();
            SetFolder("\\");
        }

        public static void SetFolder(string f)
        {
            folder = ts.GetFolder(f);
        }

        public static void CreateTaskMinutely(string name, string author, string desc, string exePath, int repeatMinute, bool startOnLogon)
        {
            ITaskDefinition task = ts.NewTask(0);
            task.RegistrationInfo.Author = author;
            task.RegistrationInfo.Description = desc;
            if(repeatMinute > 0)
            {
                ITimeTrigger trig = (ITimeTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_TIME);
                trig.Repetition.Interval = string.Format("PT{0}M", repeatMinute);
                trig.StartBoundary = "1970-01-01T00:00:00";
            }
            if(startOnLogon)
            {
                ITimeTrigger trig2 = (ITimeTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
            }
            IExecAction action = (IExecAction)task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
            action.Path = exePath;

            IRegisteredTask regTask = folder.RegisterTaskDefinition(
                                 name,
                                 task,
                                 (int)_TASK_CREATION.TASK_CREATE,
                                 null, //user
                                 null, // password
                                 _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                                 "");

            IRunningTask runTask = regTask.Run(null);
        }

        public static void CreateTaskDaily(string name, string author, string desc, string exePath, int repeatMinute, bool startOnLogon)
        {
            ITaskDefinition task = ts.NewTask(0);
            task.RegistrationInfo.Author = author;
            task.RegistrationInfo.Description = desc;
            if (repeatMinute > 0)
            {
                ITimeTrigger trig = (ITimeTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_DAILY);
            }
            if (startOnLogon)
            {
                ITimeTrigger trig2 = (ITimeTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
            }
            IExecAction action = (IExecAction)task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
            action.Path = exePath;

            IRegisteredTask regTask = folder.RegisterTaskDefinition(
                                 name,
                                 task,
                                 (int)_TASK_CREATION.TASK_CREATE,
                                 null, //user
                                 null, // password
                                 _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                                 "");

            IRunningTask runTask = regTask.Run(null);
        }

        public static void CreateTaskWeekly(string name, string author, string desc, string exePath, int repeatMinute, bool startOnLogon)
        {
            ITaskDefinition task = ts.NewTask(0);
            task.RegistrationInfo.Author = author;
            task.RegistrationInfo.Description = desc;
            if (repeatMinute > 0)
            {
                ITimeTrigger trig = (ITimeTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_WEEKLY);
            }
            if (startOnLogon)
            {
                ITimeTrigger trig2 = (ITimeTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
            }
            IExecAction action = (IExecAction)task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
            action.Path = exePath;

            IRegisteredTask regTask = folder.RegisterTaskDefinition(
                                 name,
                                 task,
                                 (int)_TASK_CREATION.TASK_CREATE,
                                 null, //user
                                 null, // password
                                 _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                                 "");

            IRunningTask runTask = regTask.Run(null);
        }

        public static void CreateTaskMonthly(string name, string author, string desc, string exePath, int repeatMinute, bool startOnLogon)
        {
            ITaskDefinition task = ts.NewTask(0);
            task.RegistrationInfo.Author = author;
            task.RegistrationInfo.Description = desc;
            if (repeatMinute > 0)
            {
                ITimeTrigger trig = (ITimeTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_MONTHLY);
            }
            if (startOnLogon)
            {
                ITimeTrigger trig2 = (ITimeTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
            }
            IExecAction action = (IExecAction)task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
            action.Path = exePath;

            IRegisteredTask regTask = folder.RegisterTaskDefinition(
                                 name,
                                 task,
                                 (int)_TASK_CREATION.TASK_CREATE,
                                 null, //user
                                 null, // password
                                 _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                                 "");

            IRunningTask runTask = regTask.Run(null);
        }

        public static void DeleteTask(string name)
        {
            folder.DeleteTask(name, 0);
        }

        public static bool IsTaskExists(string name)
        {
            return folder.GetTask(name) != null;
        }
    }
}
