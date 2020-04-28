$cert = New-SelfSignedCertificate -Type CodeSigningCert `
    -CertStoreLocation Cert:\CurrentUser\My\ -KeyLength 2048 `
    -Subject "CN=com.github.couven92,OU=com.github.couven92.xamarinplayground.notes,G=Fredrik Høisæther,SN=Rasch,L=Tromsø,C=NO,E=fredrik.rasch@gmail.com"
$p12FileName = Join-Path $PSScriptRoot "$([System.IO.Path]::GetFileName($PSScriptRoot)).p12"
$p12FileItem = $cert | Export-PfxCertificate -FilePath $p12FileName `
    -Password $(Read-Host -AsSecureString -Prompt "PKCS#12 Password") `
    -Verbose
Write-Host "Code Signing Certificate exported to: " $p12FileItem.FullName
