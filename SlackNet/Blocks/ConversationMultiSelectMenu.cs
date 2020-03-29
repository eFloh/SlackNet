﻿using System.Collections.Generic;

namespace SlackNet.Blocks
{
    /// <summary>
    /// This multi-select menu will populate its options with a list of public and private channels, DMs, and MPIMs visible to the current user in the active workspace.
    /// </summary>
    [SlackType("multi_conversations_select")]
    public class ConversationMultiSelectMenu : SelectMenuBase
    {
        public ConversationMultiSelectMenu() : base("multi_conversations_select") { }

        /// <summary>
        /// A list of one or more IDs of any valid conversations to be pre-selected when the menu loads.
        /// </summary>
        public IList<string> InitialConversations { get; set; } = new List<string>();

        /// <summary>
        /// Specifies the maximum number of items that can be selected in the menu. Minimum number is 1.
        /// </summary>
        public int? MaxSelectedItems { get; set; }
    }

    [SlackType("multi_conversations_select")]
    public class ConversationMultiSelectAction : BlockAction
    {
        public IList<string> SelectedConversations { get; set; } = new List<string>();
    }

    [SlackType("multi_conversations_select")]
    public class ConversationMultiSelectValue : ElementValue
    {
        public IList<string> SelectedConversations { get; set; } = new List<string>();
    }
}