# 🎮 개인 프로젝트 — Unity 구현 과제

## 구현 목록

- **기본 이동 및 점프** `Input System`, `Rigidbody ForceMode` (난이도 : ★★☆☆☆)
- - ![기본 이동](https://github.com/user-attachments/assets/03d1c425-f585-4b8a-b207-1bc4d6fc8866)
  - 플레이어 이동(WASD), 점프(Space) 구현
  - ![점프](https://github.com/user-attachments/assets/b09169c4-31f2-4585-aeb5-a6eb2621ab5d)

  - `Input System`을 사용하여 입력 처리, `Rigidbody`에 힘을 가해 물리 기반 이동 구현
  


- **체력바 UI** `UI` (난이도 : ★★☆☆☆)  
  - UI Canvas에 체력바 추가  
  - 플레이어의 체력 변화에 따라 UI가 실시간 갱신되도록 구현

- **동적 환경 조사** `Raycast`, `UI` (난이도 : ★★★☆☆)  
  - `Raycast`로 플레이어가 바라보는 오브젝트 탐지  
  - 탐지된 오브젝트의 이름·설명을 UI에 표시

- **점프대** `Rigidbody ForceMode` (난이도 : ★★★☆☆)  
  - 플레이어가 점프대에 닿으면 위로 튀어오르게 구현  
  - `OnCollisionEnter` 트리거와 `ForceMode.Impulse` 사용

- **아이템 데이터** `ScriptableObject` (난이도 : ★★★☆☆)  
  - 아이템 정보를 `ScriptableObject`로 관리  
  - 이름, 설명, 속성 등을 데이터 자산으로 정의

- **아이템 사용** `Coroutine` (난이도 : ★★★☆☆)  
  - 특정 아이템 사용 후 일정 시간 동안 효과 지속  
  - 예시:
    - **스피드 부스트(Speed Boost)**: 일정 시간 동안 이동 속도 증가
    - **더블 점프(Double Jump)**: 일정 시간 동안 2단 점프 가능
    - **무적(Invincibility)**: 일정 시간 동안 피해 무효화

- **3인칭 시점** (난이도 : ★★★☆☆)  
  - 기존 1인칭 시점을 3인칭으로 변경  
  - 카메라가 플레이어를 따라다니도록 세팅

- **다양한 아이템 구현** (난이도 : ★★★★☆)  
  - 추가 아이템 제작 및 기능 확장
