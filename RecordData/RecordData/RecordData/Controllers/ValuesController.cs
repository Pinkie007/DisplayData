﻿using RecordData.ApplicationLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RecordData.Controllers
{

    public class ValuesController : ApiController
    {         
            private readonly IValueService _valueService;

            public ValuesController(IValueService valueService)
            {
                _valueService = valueService;
            }

            // GET api/values
            public IEnumerable<int> Get()
            {
                return _valueService.GetValues();
            }

            // GET api/values/5
            public int? Get(Guid id)
            {
            return _valueService.GetValue(id);
            }

            // POST api/values
            public string Post([FromBody]int value)
            {
                  return _valueService.AddValue(value);
            }

            // PUT api/values/5
            public void Put(int id, [FromBody]string value)
            {
            }

            // DELETE api/values/5
            public void Delete(int id)
            {
            }
        }
    }

