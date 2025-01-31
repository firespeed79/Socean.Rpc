﻿using System;

namespace Socean.Rpc.Core
{
    public enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error
    }

    public static class LogAgent
    {
        public static LogLevel Level = LogLevel.Info;

        public static Action<LogLevel, string, Exception> LogAction = (level, message, ex) =>
        {
            if (level >= Level)
                Console.WriteLine("{0} [{1}] {2} {3}", DateTime.Now, level, message, ex);
        };

        internal static void Warn(string message, Exception ex = null)
        {
            try
            {
                var logAction = LogAction;
                logAction?.Invoke(LogLevel.Warn, message, ex);
            }
            catch 
            {
                 
            }
        }

        internal static void Error(string message, Exception ex = null)
        {
            try
            {
                var logAction = LogAction;
                logAction?.Invoke(LogLevel.Error, message, ex);
            }
            catch 
            {
             
            }
        }

        internal static void Debug(string message, Exception ex = null)
        {
            try
            {
                var logAction = LogAction;
                logAction?.Invoke(LogLevel.Debug, message, ex);
            }
            catch  
            {
                 
            }
        }

        internal static void Info(string message, Exception ex = null)
        {
            try
            {
                var logAction = LogAction;
                logAction?.Invoke(LogLevel.Info, message, ex);
            }
            catch 
            {
               
            }
        }
    }
}
