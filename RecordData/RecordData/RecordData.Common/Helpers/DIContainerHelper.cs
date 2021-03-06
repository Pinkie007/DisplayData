﻿using Microsoft.Practices.Unity;
using RecordData.ApplicationLogic.Interfaces;
using RecordData.ApplicationLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using RecordData.Data;

namespace RecordData.Common.Helpers
{
   public class DIContainerHelper
    {
          public static void RegisterComponents<T>(UnityContainer container) where T : LifetimeManager, new()
        {
            container.RegisterType<IValueService, ValueService>(new T());
            container.RegisterType<IElasticClient, AppElasticClient>(new T());
        }
    }

    }
