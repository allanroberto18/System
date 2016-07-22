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

CREATE TABLE [dbo].[usuarios_acessos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_id] [int] NOT NULL,
	[created] [datetime] NULL,
	[updated] [datetime] NULL,
	[status] [int] NOT NULL CONSTRAINT [DF_usuarios_acessos_status]  DEFAULT ((1)),
 CONSTRAINT [PK_usuarios_acessos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[usuarios_acessos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_acessos_to_usuarios] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuarios] ([Id])
GO

ALTER TABLE [dbo].[usuarios_acessos] CHECK CONSTRAINT [FK_usuarios_acessos_to_usuarios]
GO

INSERT INTO [dbo].[usuarios]
       ([nome] ,[email] ,[senha] ,[created] ,[updated] ,[status])
     VALUES
        ('Allan Roberto','master@smssim.com','$2a$06$tGOyq9eykMcYpz3tgLxES.g9CEzBB2siuSPzlxxCYxBmTgYYf0yny', '2015-12-10 13:03:12.000', '2015-12-10 13:03:12.000', 1)
GO

INSERT INTO [dbo].[usuarios]
       ([nome] ,[email] ,[senha] ,[created] ,[updated] ,[status])
     VALUES
        ('Usuário do Sistema','smssim@smssim.com','$2a$06$DIfxyg6nEkA/7VFf2jQZx.h3GMfnfLf.8VvkcXbqiHv8iPGuO.fSa', '2015-12-10 13:03:12.000', '2016-02-11 12:32:53.000', 1)
GO

INSERT INTO [dbo].[mensagens]
           ([tipo] ,[mensagem] ,[sexo] ,[created] ,[updated] ,[status])
     VALUES
           (1, 'Feliz Aniversário', 3, '2016-06-07 14:03:04.173', '2016-06-07 14:03:04.173', 1)
GO
