Echo Off
SET SPLANGEXT=cs

Echo Backing up previous version of generated code...

IF NOT EXIST .\PreviousVersionGeneratedCode MkDir .\PreviousVersionGeneratedCode
IF EXIST Delegations.cs xcopy /Y/V Delegations.cs .\PreviousVersionGeneratedCode

Echo Generating code....
SPMetal /web:http://windows-emavpj7/sites/Delegations/ /code:Delegations.%SPLANGEXT% /parameters:Parameters.xml
