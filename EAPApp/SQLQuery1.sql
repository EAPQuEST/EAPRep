CREATE TABLE [dbo].[candidate_details] (
    [candidate_id]              VARCHAR (10)  NOT NULL,
    [candidate_name]            VARCHAR (20)  NOT NULL,
    [candidate_dob]             DATE          NOT NULL,
    [candidate_address]         VARCHAR (150) NOT NULL,
    [candidate_10th_school]     VARCHAR (50)  NOT NULL,
    [candidate_10th_percentage] FLOAT (53)    NOT NULL,
    [candidate_12th_school]     VARCHAR (50)  NOT NULL,
    [candidate_12th_percentage] FLOAT (53)    NOT NULL,
    [candiate_physics]          FLOAT (53)    NOT NULL,
    [candiate_chemistry]        FLOAT (53)    NOT NULL,
    [candiate_maths]            FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([candidate_id] ASC)
);

CREATE TABLE [dbo].[candidate_preference] (
    [candidate_id]        VARCHAR (10) NOT NULL,
    [college_preference1] VARCHAR (50) NOT NULL,
    [college_preference2] VARCHAR (50) NOT NULL,
    [college_preference3] VARCHAR (50) NOT NULL,
    [course_preference11] VARCHAR (50) NOT NULL,
    [course_preference12] VARCHAR (50) NOT NULL,
    [course_preference13] VARCHAR (50) NOT NULL,
    [course_preference21] VARCHAR (50) NOT NULL,
    [course_preference22] VARCHAR (50) NOT NULL,
    [course_preference23] VARCHAR (50) NOT NULL,
    [course_preference31] VARCHAR (50) NOT NULL,
    [course_preference32] VARCHAR (50) NOT NULL,
    [course_preference33] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([candidate_id] ASC)
);

CREATE TABLE [dbo].[college_details] (
    [college_id]      VARCHAR (10)  NOT NULL,
    [college_name]    VARCHAR (50)  NOT NULL,
    [total_seats]     INT           NOT NULL,
    [college_address] VARCHAR (150) NOT NULL,
    [college_phone]   BIGINT        NOT NULL,
    PRIMARY KEY CLUSTERED ([college_id] ASC)
);

CREATE TABLE [dbo].[course_details] (
    [course_id]              VARCHAR (10) NOT NULL,
    [course_name]            VARCHAR (50) NOT NULL,
    [course_seats_available] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([course_id] ASC)
);

CREATE TABLE [dbo].[entrance_details] (
    [entrance_id]           VARCHAR (20) NOT NULL,
    [entrance_rank]         INT          NOT NULL,
    [entrance_science_mark] FLOAT (53)   NOT NULL,
    [entrance_maths_mark]   FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([entrance_id] ASC)
);

CREATE TABLE [dbo].[password_details] (
    [username]  VARCHAR (20) NOT NULL,
    [password]  VARCHAR (10) NOT NULL,
    [user_type] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([username] ASC)
);

CREATE TABLE [dbo].[verification_details] (
    [entrance_id]    VARCHAR (50) NOT NULL,
    [candidate_name] VARCHAR (50) NOT NULL,
    [entrance_rank]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([entrance_id] ASC)
);

CREATE TABLE [dbo].[view_allotment] (
    [candidate_id]     VARCHAR (20) NOT NULL,
    [candidate_name]   VARCHAR (50) NOT NULL,
    [college_alloted]  VARCHAR (50) NOT NULL,
    [course_alloted]   VARCHAR (50) NOT NULL,
    [allotment_status] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([candidate_id] ASC)
);


