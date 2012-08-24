﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Http {

    public class BlogHttpResponseMessage<T> : BlogHttpResponseMessage {

        public T Model { get; set; }
    }
}