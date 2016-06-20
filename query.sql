CREATE TABLE [dbo].[configuracoes] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [data_inicial] DATE     NOT NULL,
    [data_final]   DATE     NOT NULL,
    [created]      DATETIME NULL,
    [updated]      DATETIME NULL,
    [status]       INT      DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[contatos] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [nome]            NVARCHAR (250) NOT NULL,
    [sexo]            INT            DEFAULT ((1)) NOT NULL,
    [telefone]        NVARCHAR (15)  NOT NULL,
    [data_nascimento] DATE           NULL,
    [created]         DATETIME       NULL,
    [updated]         DATETIME       NULL,
    [status]          INT            DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[grupos] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [nome]    NVARCHAR (250) NOT NULL,
    [created] DATETIME       NULL,
    [updated] DATETIME       NULL,
    [status]  INT            DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[mensagens] (
    [Id]       INT      IDENTITY (1, 1) NOT NULL,
    [tipo]     INT      DEFAULT ((1)) NOT NULL,
    [mensagem] TEXT     NOT NULL,
    [sexo]     INT      DEFAULT ((3)) NOT NULL,
    [created]  DATETIME NULL,
    [updated]  DATETIME NULL,
    [status]   INT      DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[licencas] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [licenca] NVARCHAR (255) NOT NULL,
    [created] DATETIME       NULL,
    [updated] DATETIME       NULL,
    [status]  INT            DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_licencas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[usuarios] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [nome]    NVARCHAR (250) NOT NULL,
    [email]   NVARCHAR (250) NOT NULL,
    [senha]   NVARCHAR (250) NOT NULL,
    [created] DATETIME       NULL,
    [updated] DATETIME       NULL,
    [status]  INT            DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[sims] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [sim]        NVARCHAR (50) NOT NULL,
    [quantidade] INT           NOT NULL,
	[data_atual] DATE		   NOT NULL,
    [created]    DATETIME      NULL,
    [updated]    DATETIME      NULL,
    [status]     INT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[grupos_contatos] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [grupo_id]   INT      NOT NULL,
    [contato_id] INT      NOT NULL,
    [created]    DATETIME NULL,
    [updated]    DATETIME NULL,
    [status]     INT      DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_grupos_contatos_to_grupos] FOREIGN KEY ([grupo_id]) REFERENCES [dbo].[grupos] ([Id]),
    CONSTRAINT [FK_grupos_contatos_to_contatos] FOREIGN KEY ([contato_id]) REFERENCES [dbo].[contatos] ([Id])
);

CREATE TABLE [dbo].[grupos_mensagens] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [grupo_id]	  INT      NOT NULL,
    [mensagem_id] INT      NOT NULL,
    [created]     DATETIME NULL,
    [updated]     DATETIME NULL,
    [status]      INT      DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_grupos_mensagens_to_grupos] FOREIGN KEY ([grupo_id]) REFERENCES [dbo].[grupos] ([Id]),
    CONSTRAINT [FK_grupos_mensagens_to_mensagens] FOREIGN KEY ([mensagem_id]) REFERENCES [dbo].[mensagens] ([Id])
);

CREATE TABLE [dbo].[contatos_mensagens] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [contato_id]  INT      NOT NULL,
    [mensagem_id] INT      NOT NULL,
    [created]     DATETIME NULL,
    [updated]     DATETIME NULL,
    [status]      INT      DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_contatos_mensagens_to_contatos] FOREIGN KEY ([contato_id]) REFERENCES [dbo].[contatos] ([Id]),
    CONSTRAINT [FK_contatos_mensagens_to_mensagens] FOREIGN KEY ([mensagem_id]) REFERENCES [dbo].[mensagens] ([Id])
);

CREATE TABLE [dbo].[agendas_mensagens] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [mensagem_id] INT      NOT NULL,
    [data_envio]  DATE     NOT NULL,
    [created]     DATETIME NULL,
    [updated]     DATETIME NULL,
    [status]      INT      DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_agendas_mensagens] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_agendas_mensagens_to_mensagens] FOREIGN KEY ([Id]) REFERENCES [dbo].[mensagens] ([Id])
);

CREATE TABLE [dbo].[mensagens_disparos] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [mensagem_id] INT      NOT NULL,
    [contato_id]  INT      NOT NULL,
    [tamanho]     INT      NOT NULL,
    [data_envio]  DATETIME NOT NULL,
    [created]     DATETIME NULL,
    [updated]     DATETIME NULL,
    [status]      INT      DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_mensagens_disparos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_mensagens_disparos_to_contato] FOREIGN KEY ([contato_id]) REFERENCES [dbo].[contatos] ([Id]),
    CONSTRAINT [FK_mensagens_disparos_to_mensagens] FOREIGN KEY ([mensagem_id]) REFERENCES [dbo].[mensagens] ([Id])
);

CREATE TABLE [dbo].[promocoes] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [mensagem_id] INT      NOT NULL,
    [vencimento]  DATE     NOT NULL,
    [created]     DATETIME NULL,
    [updated]     DATETIME NULL,
    [status]      INT      DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_promocoes_To_mensagem] FOREIGN KEY ([mensagem_id]) REFERENCES [dbo].[mensagens] ([Id])
);

CREATE TABLE [dbo].[codigos_promocionais] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [promocao_id] INT           NOT NULL,
    [contato_id]  INT           NOT NULL,
    [codigo]      NVARCHAR (50) NOT NULL,
    [created]     DATETIME      NULL,
    [updated]     DATETIME      NULL,
    [status]      INT           DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_codigos_promocionais] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_codigos_promocionais_to_promocao] FOREIGN KEY ([promocao_id]) REFERENCES [dbo].[promocoes] ([Id]),
    CONSTRAINT [FK_codigos_promocionais_to_contato] FOREIGN KEY ([contato_id]) REFERENCES [dbo].[contatos] ([Id])
);

