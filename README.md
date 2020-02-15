# Computer Graphics
> 2019-2 ComputerGraphics Team project로써,<br/> 
Unity, Vuforia, Arduino 그리고 Bluetooth를 활용한 **Coin Dozer** 증강현실 앱을 제작했습니다.  

<br/>

## 📖 Introduction  

Unity와 Arduino를 이용한 혼합현실 Contents 제작하는 것으로 써 제작 목표는 아래와 같습니다.
1. 카메라를 통해 타겟 이미지를 인식하고 오브젝트 출력
2. 오브젝트 텍스쳐 맵핑
3. 오브젝트간의 상호작용
4. 아두이노의 센서와 블루투스 통신 모듈을 이용해 현실세계와 게임 속 변화를 실시간으로 적용 (Mixed Reality 구현)
  <br/><br/>
## 👨‍💻 System requirements
우선 유니티, 뷰포리아, 아두이노를 활용해 진행하는 프로젝트입니다. 따라서 유니티, 뷰포리아, 안드로이드 스튜디오,아두이노의 설치가 필요합니다.  
<img src="https://user-images.githubusercontent.com/56837413/74585813-7b8b6880-5024-11ea-8d0a-0f02c7355996.PNG" width="80%"></img><br/><br/>
유니티는 Unity 2018.4.11f1 (64-bit)버전을 사용하였으며 안드로이드를 타켓 플랫폼으로 빌드하였습니다.<br/>
**Minimum API Level**은 20<br/> **Scripting Runtime Version Setting**은 .NET 4.x Equivalent<br/> **Api Compatibility Level**은 .NET 4.x를 세팅했습니다.<br/>
**XR Setting**을 통해 Virtual Reality Supported를 활성화 하고 Vuforia도 활성화 했습니다.<br/><br/>
아두이노는 1.8.10ver를 기반으로 제작하였으며 아두이노 우노를 사용해 제작했습니다.<br/><br/>
안드로이드 스튜디오는 안드로이드 기반 **블루투스 작동**을 위해 유니티에서 사용 가능한 jar파일 제작에 사용하였습니다.
  <br/><br/>
## ✨ About Coin Dozer
<img src="https://user-images.githubusercontent.com/56837413/74585894-2ef45d00-5025-11ea-8cc2-5d2397a12c3b.PNG" width="80%"></img><br/><br/>
Coin Dozer 오락기를 제작하는 것으로, 유럽 등지의 오락실에 있는 게임기로 간단하게 돈넣고 돈따는 오락기라고 할 수 있습니다.
Coin Dozer 오락기의 동작 과정은 아래와 같습니다.

1. 오락기 내부 floor에 동전들이 겹겹이 쌓여있음.
2. 동전을 넣으면 Back panal 쪽 하단에서 pusher floor가 앞,뒤로 움직이며 floor에 쌓여있는 동전을 밈.
3. User가 동전을 투입.
4. 기기내 어딘가에 user의 동전이 쌓이며 pusher에 의해 밀리며 다른 동전이 떨어지게 만듬.

  <br/>
  
## ✨ Coin Dozer 동작 예시
<br/>

> ### 기본 구조
<img src="https://user-images.githubusercontent.com/56837413/74586038-abd40680-5026-11ea-91c7-3326e2ef0d0b.PNG" width="80%"></img><br/><br/><br/><br/><br/><br/>  
  
> ### 동전 투입시
<img src="https://user-images.githubusercontent.com/56837413/74586049-e2118600-5026-11ea-9c8a-e42b735bd607.PNG" width="80%"></img>
  <br/><br/><br/><br/><br/><br/>  
  
> ### 동전 배출시
<img src="https://user-images.githubusercontent.com/56837413/74586053-e9d12a80-5026-11ea-8f9a-7aaa700507b3.PNG" width="80%"></img>
  <br/> <br/>
  
## 📝 Todo list
제작할 코드와 문서들입니다.

- [x] [💻] 뷰포리아 이미지 타겟 생성
- [x] [💻] 코인 오브젝트 생성
- [x] [💻] 코인 도저 기기 오브젝트 생성
- [x] [💻] 안드로이드 블루투스 jar 제작
- [x] [💻] 아두이노 회로도 제작 및 부품 연결
- [x] [💻] 블루투스 연결/해제 버튼 생성
- [x] [💻] 유티니에서 블루투스 제어 기능 활성화
- [x] [📗] 유니티내 코인도저 움직임 구현
- [x] [📗] 아두이노에서 코인입력이 오면 앱 내에서 Clone
- [x] [📗] 앱 내에서 코인이 배출구에 빠지면 아두이노 제어를 통해 오프라인 내 동전 배출
- [x] [🔨] 코인 텍스쳐 맵핑
- [x] [🔨] 코인 도저 오브젝트 텍스쳐 맵핑
- [x] [🔨] 아두이노를 설치할 수 있는 동전 박스 제작 및 설치
- [x] [🔒] 테스팅
  <br/> <br/>
  
## 📝 뷰포리아 타겟 이미지
<img src="https://user-images.githubusercontent.com/56837413/74586121-afb45880-5027-11ea-8aa8-8d028f053566.png" width="40%"></img>
   <br/> <br/>
   
## 📝 Coin 오브젝트 생성 및 텍스쳐 맵핑
<img src="https://user-images.githubusercontent.com/56837413/74585967-f012d700-5025-11ea-9f0f-718841bb1d2c.png" width="80%"></img>
  <br/> <br/>
  
## 📝 Coin Dozer 기기 오브젝트 생성 및 텍스쳐 맵핑
<img src="https://user-images.githubusercontent.com/56837413/74586086-46cce080-5027-11ea-9254-410c3953d24b.png" width="80%"></img>
   <br/> <br/>
   
## 📝 Coin Dozer 데이터 통신 방식
<img src="https://user-images.githubusercontent.com/56837413/74586090-4e8c8500-5027-11ea-93a3-3d530eaeddf0.PNG" width="80%"></img>
   <br/> 
   위 이미지는 이해를 돕기위한 이미지로 실제 안드로이드와 통신하기 보다, 안드로이드 스튜디오에서 제작한 Plugin을 Unity에 import해 사용하고 데이터를 전달한다고 할 수 있습니다. 
   <br/><br/>
   
## 📝 아두이노 회로도
<img src="https://user-images.githubusercontent.com/56837413/74586106-81367d80-5027-11ea-9d52-7fe337a04f3c.PNG" width="80%"></img>
   <br/> <br/>
   
## 📝 아두이노 동전 박스내 임시 설치
<img src="https://user-images.githubusercontent.com/56837413/74586181-76c8b380-5028-11ea-963f-2ca428351afb.PNG" width="80%"></img>
   <br/> <br/>

## 📝 작동 테스팅
<img src="https://user-images.githubusercontent.com/56837413/74586194-8f38ce00-5028-11ea-8894-571f84bacb2d.PNG" width="80%"></img>
   <br/> <br/>
   
## 📝 Coin Dozer 로고
<img src="https://user-images.githubusercontent.com/56837413/74586192-86e09300-5028-11ea-96f5-6451f17fb7b2.jpg" width="30%"></img>
   <br/> <br/>

## ☁️ 결과물
[![Video Label](http://img.youtube.com/vi/XmdurZLA57g/0.jpg)](https://youtu.be/XmdurZLA57g)
<br/>  

위 이미지 클릭시 동영상이 재생됩니다.
