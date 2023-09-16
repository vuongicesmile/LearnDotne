var WIDTH = window.innerWidth - 30,
    HEIGHT = window.innerHeight - 30;
 
var angle = 45, // góc nhìn
    aspect = WIDTH / HEIGHT, // tỷ lệ khung hình
    near = 0.1, // khoảng cách gần nhất
    far = 3000; // khoảng cách xa nhất

var container = document.getElementById('container');
/**
 * PerspectiveCamera : Lớp để sử dụng tạo và điều khiển camera 3D trong một không
 * gian 3 chiều.
 * theo phương pháp : perspective projection 
 * fov (angle) : đây là góc nhìn mà camera có thể nhìn thấy trong không gian 3d
 * giá trị fov càng lớn , camera nhìn càng được nhiều hơn (0 - 180)
 * aspect : tỷ lệ khung hình của camera , tức là tỉ lệ giữa chiều rộng và chiều cao
 * của khu vực mà camera hiển thị. ( thông thường là tỷ lệ màn hình hiển thị)
 * near và far : đây là khoảng cách gần nhất và xa nhất mà camera có thể nhìn
 * thấy. Các đối tươnh nằm trong khoảng sẽ được hiện thị phối cảnh
 *  */ 
var camera = new THREE.PerspectiveCamera(angle, aspect, near, far);
// xyz
camera.position.set(0, 0, 0);
var scene = new THREE.Scene();
/**
 * tạo và kiểm soát ánh sáng điểm trong không gian 3D
 * đối tượng này tạo ra một nguồn sáng tại 1 vị trí cụ thể và phát ra ánh sáng hình nón
 * có hướng tầm quan sát
 * 1/ màu của ánh sáng 
 * 2/ cường độ ánh sáng
 * 3/ khoảng cách tớI nguồn sáng : 0 tức là nguồn sáng được đặt tại vị trí của camera
 *  4/ góc cụt của ánh sáng , đại diện cho góc mở của cung ánh sang hình nón ,
 * góc cụt là 90 độ 
 * 1 : hệ số giảm ánh sáng , đại diện cho sự giảm dần của ánh sáng khi nó xa 
 * khỏi nguồn sáng
 */
var light = new THREE.SpotLight(0xFFFFFF, 1, 0, Math.PI / 2, 1);
// đặt vị trí của spot light
light.position.set(4000, 4000, 1500);
// đặt mục tiêu ánh sáng
light.target.position.set (1000, 3800, 1000);
// thêm ánh sáng vào scene
scene.add(light);
/**
 * tạo đỐi tượng hình cầu có các thuộc tính 
 * 30 : bán kính của hình cầu 
 * 40 : số đoạn dọc của hình cầu , đại diện số lượnG đoạn dọc hình cầu 
 * giá trị càng lớn thì hình cầu càng mịn 
 * 400 : số đoạn ngang của hình cầU
 */
var earthGeo = new THREE.SphereGeometry (30, 40, 400), 
    earthMat = new THREE.MeshPhongMaterial();  // tạo vật liệU cho hình cầU

// diffuse map
earthMat.map = THREE.ImageUtils.loadTexture('https://s3-us-west-2.amazonaws.com/s.cdpn.io/123941/earthmap.jpg');

// bump map
/**
 * đồ hoạ máy tính : giúp tạo hiệU ứng gợn sóng , đỒi núi hoặc các chi tiết 
 * bề măt
 */
earthMat.bumpMap = THREE.ImageUtils.loadTexture('https://s3-us-west-2.amazonaws.com/s.cdpn.io/123941/bump-map.jpg');
earthMat.bumpScale = 8;// chỉnh đỘ sâu của thuộc tính bump map
var earthMesh = new THREE.Mesh(earthGeo, earthMat);
earthMesh.position.set(-100, 0, 0); 
earthMesh.rotation.y=5; // đặt góc quay một góc 5 radian quanh trục y

scene.add(earthMesh);
// nhìn vào đỐi tuọng earth mesh
camera.lookAt( earthMesh.position );

//Renderer code. We'll get to this in a moment
// tạo đối tượng : thuộc tính antiliasing được đặt là true để làm mịn các đƯờng viền
var renderer = new THREE.WebGLRenderer({antialiasing : true});
renderer.setSize(WIDTH, HEIGHT);
renderer.domElement.style.position = 'relative';


container.appendChild(renderer.domElement);
renderer.autoClear = false; // vẽ nhiều đối tượng lên cùng mộ khung hình mà không xoá  mất các đỐi tượng đã vẽ
renderer.shadowMapEnabled = true; // cho phép render tạo bản đồ bóng đổ 
// để hiện thị bóngd dổ từ các nguồn sáng

function animate() {
  requestAnimationFrame(animate); // kích hoạt một vòng lặp render liên tục và đồng bộ hoá vớI tốc độ làm mớI của trình duyệt
  render(); // vẽ scene
}

// hàm render để render scene với camera
function render () {
  var clock = new THREE.Clock(),
  delta = clock.getDelta(); 

earthMesh.rotation.y += 1000 * delta;
renderer.render(scene, camera);
  // cập nhật và hiện thị scene liên tục lên màn hình
}

animate();