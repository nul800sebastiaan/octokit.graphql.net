namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdatePullRequestReviewComment
    /// </summary>
    public class UpdatePullRequestReviewCommentPayload : QueryableValue<UpdatePullRequestReviewCommentPayload>
    {
        internal UpdatePullRequestReviewCommentPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The updated comment.
        /// </summary>
        public PullRequestReviewComment PullRequestReviewComment => this.CreateProperty(x => x.PullRequestReviewComment, Octokit.GraphQL.Model.PullRequestReviewComment.Create);

        internal static UpdatePullRequestReviewCommentPayload Create(Expression expression)
        {
            return new UpdatePullRequestReviewCommentPayload(expression);
        }
    }
}