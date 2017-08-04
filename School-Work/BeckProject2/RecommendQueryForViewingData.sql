/*
This is just a recommended query for viewing the data so it's easier to understand how everything is tied together. 
This database is designed to inventory claims submitted to an auto insurance company
*/

USE Inventory

-- Claim_Header stores general information about an insurance claim. This would be the "Heading" of the claim
SELECT * 
FROM dbo.Claim_Heading 
ORDER BY claimNumber, claimHeadingID

-- Claim_Details stores more specific information and would be found lower on a claim report. It breaks the general info down int segments based on different smaller claims
SELECT * 
FROM dbo.Claim_Details
ORDER BY claimNumber, lineNumber


-- Joining the two together will give you a full overview for a specific line of a claim and how it relates to the heading
SELECT	 cd.claimHeadingID
		,cd.claimDetailsID
		,cd.claimNumber
		,cd.lineNumber
		,ch.firstName
		,ch.lastName
		,ch.groupNumber
		,cd.itemDamages
		,ch.totalDamages
		,ch.changeReason
FROM dbo.Claim_Details cd
INNER JOIN dbo.Claim_Heading ch
	ON cd.claimHeadingID = ch.ClaimHeadingID
ORDER BY cd.claimNumber, cd.lineNumber, cd.claimDetailsID
