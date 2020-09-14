namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of DeleteProject
    /// </summary>
    public class DeleteProjectInput
    {
        /// <summary>
        /// The Project ID to update.
        /// </summary>
        public ID ProjectId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}