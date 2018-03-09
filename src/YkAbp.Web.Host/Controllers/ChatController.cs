﻿using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YkAbp.Core.Chat;
using YkAbp.Core.Storage;
using YkAbp.Web.Core.Controllers;

namespace YkAbp.Web.Host.Controllers
{
    public class ChatController : ChatControllerBase
    {
        public ChatController(IBinaryObjectManager binaryObjectManager, IChatMessageManager chatMessageManager) :
            base(binaryObjectManager, chatMessageManager)
        {
        }

        public async Task<ActionResult> GetUploadedObject(Guid fileId, string contentType)
        {
            using (CurrentUnitOfWork.SetTenantId(null))
            {
                var fileObject = await BinaryObjectManager.GetOrNullAsync(fileId);
                if (fileObject == null)
                {
                    return StatusCode((int)HttpStatusCode.NotFound);
                }

                return File(fileObject.Bytes, contentType);
            }
        }
    }
}