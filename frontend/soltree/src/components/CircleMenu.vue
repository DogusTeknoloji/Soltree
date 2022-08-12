<template>
  <div class='wrapper' :class="isOpen ? 'open' : ''">
    <ul>
      <li v-for="item in items" :class="item.Selected ? 'selected' : ''"
        :style="'transform: rotate(' + item.Rotate + 'deg);'">
        <label :onclick="() => onItemClick(item)" :style="'transform: rotate(-' + item.Rotate + 'deg);'">
          <span>{{ item.Label }}</span>
        </label>
      </li>
    </ul>
    <div class="center-area">
      <label>Hello</label>
    </div>
  </div>
</template>

<script lang="ts" setup>
import { ref } from 'vue';

interface Item {
  Label: string
  Selected?: boolean
  Rotate?: number
}
const isOpen = ref<boolean>();
const isMultipleSelect = ref<boolean>(true);

const items = ref<Item[]>([
  { Label: "Güç ve Şarj", Rotate: -360 },
  { Label: "Görüntü ve Ekran", Rotate: -360 },
  { Label: "Ses ve Müzik", Rotate: -360 },
  { Label: "Şebeke ve Sinyal", Rotate: -360 },
  { Label: "Fotoğraf Video Çekimi", Rotate: -360 },
  { Label: "Hafıza ve Uygulamalar", Rotate: -360 },
  { Label: "Diğerleri", Rotate: -360 },
]);

setTimeout(() => {
  items.value.forEach((item: Item, index: number) => {
    item.Rotate = calcAngle(index)
  });
  toggle()
}, 100);

const toggle = () => {
  isOpen.value = !isOpen.value
}

const onItemClick = (item: Item) => {
  if (!isMultipleSelect.value) {
    const selectedItems = items.value.filter((item) => { return item.Selected });

    if (selectedItems.length > 0 && selectedItems[0].Label != item.Label) {
      return
    }
  }

  item.Selected = !item.Selected
}

const calcAngle = (index: number) => {
  return 360 / items.value.length * index;
}

</script>

<style scoped>
.wrapper {
  background-color: pink;
  position: relative;
  height: 500px;
}

.center-area {
  position: absolute;
  background-color: brown;
  height: 140px;
  width: 140px;
  margin-left: -70px;
  margin-top: -70px;
  left: 50%;
  top: 50%;
  text-align: center;
  border-radius: 15%;
}

ul {
  list-style: none;
  padding: 0;
  position: absolute;
  margin-top: -90px;
  left: 50%;
  top: 50%;
}

li {
  position: absolute;
  height: 180px;
  background-color: plum;
  transform: rotate(0);
  transition: all 0.8s ease-in-out;
}

li.selected label {
  background-color: blue;
}

li label {
  position: absolute;
  background-color: red;
  text-align: center;
  border-radius: 100%;
  width: 0;
  height: 0;
  font-size: 1px;
  overflow: hidden;
  display: block;
  cursor: pointer;
  bottom: 100%;
  left: 50%;
  margin-left: -50px;
  transition: all 0.8s ease-in-out, color 0.1s, background 0.1s;
}

li label span {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
}

.wrapper.open li label {
  height: 100px;
  width: 100px;
  font-size: 14px;
}
</style>