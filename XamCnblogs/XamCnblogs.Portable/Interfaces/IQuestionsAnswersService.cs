﻿using XamCnblogs.Portable.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCnblogs.Portable.Interfaces
{
    public interface IQuestionsAnswersService
    {
        Task<ResponseMessage> GetAnswersAsync(int id);
        Task<ResponseMessage> PostAnswersAsync(int id, string content);
    }
}