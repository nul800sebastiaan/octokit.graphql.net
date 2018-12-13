namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateContentAttachment
    /// </summary>
    public class CreateContentAttachmentInput
    {
        public ID ContentReferenceId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string ClientMutationId { get; set; }
    }
}