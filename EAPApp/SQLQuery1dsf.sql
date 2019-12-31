CREATE TABLE [dbo].[candidate_registration] (
    [candidate_id] VARCHAR (10) NOT NULL,
    [candidate_name]  VARCHAR (50) NOT NULL,
	  [candidate_gender] VARCHAR (10) NOT NULL,
    [candidate_DOB]  DATE NOT NULL,
	  [candidate_phone] bigint  NOT NULL,
    [candidate_email]  VARCHAR (30) NOT NULL,
	[candidate_address]  VARCHAR (150) NOT NULL
);