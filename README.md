# GrpcAspNet

Server
1. Tạo file protobuf
2. Double click vào server project add
 <Protobuf Include="Protos\TênFileProtos.proto" GrpcService="Server"></Protobuf> vào <ItemGroup></ItemGroup>
3. build project 
4. kiểm tra xem đã generated ra được file .cs hay chưa (file nằm trong thư mục "\obj\Debug\net5.0\Protos")
5. tạo class service kế thừa từ tên service trong grpc+Base

Client
1. Coppy thư mục protos xuống
2. Double click vào client project
<Protobuf Include="Protos\TênFileProtos.proto" GrpcService="Client"></Protobuf> vào <ItemGroup></ItemGroup>
3. build project 
4. kiểm tra xem đã generated ra được file .cs hay chưa (file nằm trong thư mục "\obj\Debug\net5.0\Protos")
5. code controller
