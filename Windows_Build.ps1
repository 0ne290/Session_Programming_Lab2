if ( $args[0].length -ne 0 )
{
	if ( Test-Path -Path $args[0] )
	{
		Remove-Item $($args[0] + "/*") -Force -Recurse -Confirm:$false
	}
	dotnet publish ConsoleApplication/ConsoleApplication.csproj --configuration Release --runtime win-x64 --self-contained false --framework net8.0 --output $args[0] -p:PublishReadyToRun=true -p:PublishSingleFile=true
}
else
{
	Write-Host "The output directory path argument is mandatory."
}
