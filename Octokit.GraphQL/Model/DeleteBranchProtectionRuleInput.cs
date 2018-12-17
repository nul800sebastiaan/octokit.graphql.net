namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;;

    /// <summary>
    /// Autogenerated input type of DeleteBranchProtectionRule
    /// </summary>
    public class DeleteBranchProtectionRuleInput
    {
        /// <summary>
        /// The global relay id of the branch protection rule to be deleted.
        /// </summary>
        public ID BranchProtectionRuleId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}