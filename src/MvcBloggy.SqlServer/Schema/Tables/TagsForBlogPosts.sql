﻿CREATE TABLE [dbo].[TagsForBlogPosts] (
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[BlogPostId] UNIQUEIDENTIFIER NOT NULL,
	[TagId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [PK_TagsForBlogPosts] PRIMARY KEY ([Id])
);