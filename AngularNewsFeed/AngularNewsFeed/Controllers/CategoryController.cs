﻿using AngularNewsFeed.Manager;
using AngularNewsFeed.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularNewsFeed.Controllers
{
    public class CategoryController : ApiController
    {
        // GET: api/Catgeory
        public ResponseModel Get()
        {
            IEnumerable<Object> data;
            ResponseModel response = new ResponseModel();
            if ((data = CategoryManager.getCategories()) != null)
            {
                response.data = data;
                response.success = true;
            }
            else
            {
                response.success = false;
                response.error = "Internal Server Error";
                response.data = null;
            }
            return response;
        }

        // POST: api/Catgeory
        public ResponseModel Post([FromBody]Category category)
        {
            int data;
            ResponseModel response = new ResponseModel();
            if ((data = CategoryManager.postCategory(category)) != -1)
            {
                response.data = data;
                response.success = true;
            }
            else
            {
                response.success = false;
                response.error = "Internal Server Error";
                response.data = null;
            }
            return response;
        }
    }
}
