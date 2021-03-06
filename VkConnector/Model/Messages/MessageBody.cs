﻿namespace VkConnector.Model.Messages
{
    /// <summary>
    ///     Тело сообщения
    /// </summary>
    public class MessageBody
    {
        public MessageBody(string textMessage)
        {
            this.Text = textMessage;
        }

        /// <summary>
        ///     Текстовое сообщение
        /// </summary>
        public string Text { get; set; }
    }
}