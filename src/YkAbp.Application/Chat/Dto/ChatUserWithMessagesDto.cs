using System.Collections.Generic;

namespace YkAbp.Application.Chat.Dto
{
    public class ChatUserWithMessagesDto : ChatUserDto
    {
        public List<ChatMessageDto> Messages { get; set; }
    }
}