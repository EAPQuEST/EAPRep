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
    [candidate_email]           VARCHAR (50)  NOT NULL,
    [candidate_phone]           VARCHAR (50)  NOT NULL,
    [candidate_gender]          VARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([candidate_id] ASC)
);

